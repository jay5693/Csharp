using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application");
            if(excelType == null)
            {
                Console.WriteLine("엑셀이 설치되어있지 않거나 COM객체를 사용할 수 없습니다");
            }

            dynamic excelApp = Activator.CreateInstance(excelType);

            try
            {
                //Excel 어플리케이션 표시
                excelApp.Visible = true;
                
                //새 workbook 추가
                dynamic workbook = excelApp.Workbooks.Add();

                //첫번째 워크시트 선택
                dynamic worksheet = workbook.Sheets[1];

                worksheet.Cells[1, 1].Value = "Hello,COM!";
                worksheet.Cells[2, 1].Value = "Dynamic을 사용한 C# 예제";
                worksheet.Cells[1, 2].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                Console.WriteLine("Excel에 데이터를 성공적으로 작성했습니다.");

                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                workbook.SaveAs(savePath);
                Console.WriteLine($"파일이 다음 경로에 저장되었습니다: {savePath}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"오류 발생: {ex.Message}");
            }
            finally
            {
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                Console.WriteLine("Excel COM 객체가 해제되었습니다.");
            }
        }
    }
}
