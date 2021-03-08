using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();   // 파일 탐색기 열림
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();   // 파일 저장 위치
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다.","비동기복사완료");
        }

        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);    //동기 파일 복사
            MessageBox.Show($"{totalCopied}로 복사했습니다.","동기복사완료");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소!");
        }

        /// <summary>
        /// 동기 복사
        /// 파일 커지면 응답없음 뜸 - 스레드 사용X
        /// </summary>
        private long CopySync(string sourcePath, string targetPath)
        {
            BtnAsyncCopy.Enabled = false;   // 비동기 버튼 비활성화(Enable vs Disable)
            long totalCopied = 0;           // 전부 복사했는지

            // Copy 작업
            // open:using() {, close:} 자동(FileStream, DB에서 사용)
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open)) // 존재하는 파일 오픈
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))   // 파일 새로 생성
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1024(1KB) * 1024 == 1MB
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        targetStream.Write(buffer, 0, nRead);   // 복사
                        totalCopied += nRead;

                        // progress bar 복사상태 진행 표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }

            // Copy 끝나면
            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        /// <summary>
        /// 비동기 복사 (async, await)
        /// 파일 커져도 응답없음 안뜸 - 스레드 사용
        /// </summary>
        private async Task<long> CopyAsync(string sourcePath, string targetPath)
        {
            BtnSyncCopy.Enabled = false;   // 동기 버튼 비활성화(Enable vs Disable)
            long totalCopied = 0;           // 전부 복사했는지

            // Copy 작업
            // open:using() {, close:} 자동(FileStream, DB에서 사용)
            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open)) // 존재하는 파일 오픈
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create))   // 파일 새로 생성
                {
                    byte[] buffer = new byte[1024 * 1024];  // 1024(1KB) * 1024 == 1MB
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead);   // 복사
                        totalCopied += nRead;

                        // progress bar 복사상태 진행 표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }
            }

            // Copy 끝나면
            BtnSyncCopy.Enabled = true;
            return totalCopied;
        }
    }
}
