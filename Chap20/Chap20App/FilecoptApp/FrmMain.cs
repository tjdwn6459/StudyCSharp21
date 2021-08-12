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

namespace FilecoptApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTarget_TextChanged(object sender, EventArgs e)
        {

        }

        
        private async void BtnASyncCopy_Click(object sender, EventArgs e)
        {

            //await 피연산자가 나타내는 비동기 작업이 완료될때까지 바깥쪽 비동기 메서드의 평가를 일시 중단 aysnc 함께 써준다 
            long totalCopied = await CopyASync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다.", "비동기복사완료");
        }

        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
            MessageBox.Show($"{totalCopied}로 복사했습니다.", "동기복사완료");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("취소!");
        }

        //1)버튼을 비활성화 2) 복사 할 파일을 연다 3)복사될곳에 새로운 파일을 생성(같은 사이즈의 파일의 크기 nread를 만든다)
        //4) nread에 쪼개진 값들을 채워준다 0이 되지않을 때 까지
        private long CopySync(string sourcePath, string targetPath)
        {
            BtnASyncCopy.Enabled = false; //비동기버튼 비활성화
            long totalCopied = 0;//전부 복사했는지(전부 복사했을 경우 안의 값이 '0'이 된다)

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) //저장하는 위치에 새로운 파일을 생성
                {
                    byte[] buffer = new byte[1024 * 1024]; //1024(1KB) *1024 ==>1MB, source에서 target로 설정한 byte로 잘라서 복사댄다
                    int nRead = 0;
                    while ((nRead = sourceStream.Read(buffer, 0, buffer.Length)) != 0)// nread의 값은 위에서 쪼개진 값을 빈공간에 채울값을 말한다
                    {
                        //복사
                        targetStream.Write(buffer, 0, nRead); 
                        totalCopied += nRead; //totalCopied에서 차있는 만큼에서 반복하면서 nread의 값이 덧붙여지는것 

                        //프로그레스바에 복사 상태 진행표시 (백분율로 나타나기에 100을 곱해줘야 딱 떨어짐)
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100); 
                    }
                }    
           
         }
            //copy 끝나면
            BtnASyncCopy.Enabled = true; //다시 버튼은 활성화 
            return totalCopied;
        }

        //비동기 복사
        private async Task<long> CopyASync(string sourcePath, string targetPath)
        {
            BtnSyncCopy.Enabled = false; //비동기버튼 비활성화
            long totalCopied = 0;//전부 복사했는지

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))//존재하는 파일
            {
                using (FileStream targetStream = new FileStream(targetPath, FileMode.Create)) //새로 생성
                {
                    byte[] buffer = new byte[1024 * 1024]; //1024(1KB) *1024 ==>1MB, source에서 target로 설정한 byte로 잘라서 복사댄다
                    int nRead = 0;
                    while ((nRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await targetStream.WriteAsync(buffer, 0, nRead); //복사
                        totalCopied += nRead;

                        //프로그레스바에 복사 상태 진행표시
                        PrbCopy.Value = (int)((totalCopied / sourceStream.Length) * 100);
                    }
                }

            }
            //copy 끝나면
            BtnSyncCopy.Enabled = true;
            return totalCopied;
        }
        private void PrbCopy_Click(object sender, EventArgs e)
        {

        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            //새로운 인스턴스 생성
            OpenFileDialog dialog = new OpenFileDialog();
            //파일을 선택하고 확인을 누르면 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //파일의 이름이 TxtSource에 들어감 
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            //새로운 인스턴스 생성
            SaveFileDialog dialog = new SaveFileDialog();
            //저장할 위치의 파일을 선택하고 확인 누르면 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //저장할 위치의 파일이름이 TxtTarget에 들어간다 
                TxtTarget.Text = dialog.FileName;
            }
        }
    }
}
