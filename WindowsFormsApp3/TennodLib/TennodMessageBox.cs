using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennodLib
{
    public class TennodMessageBox
    {
        public void Show(char typeOfMessage, string message)
        {
            string SUCCESS_CAPTION = "성공";
            string ERROR_CAPTION = "실패";
            string WARNING_CAPTION = "경고";
            string FAIL_CAPTION = "실패";

            switch (typeOfMessage)
            {
                case 'S': //성공 메시지
                    MessageBox.Show(message, SUCCESS_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 'E': //오류 메시지
                    MessageBox.Show(message, ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 'W': //경고 메시지
                    MessageBox.Show(message, WARNING_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 'F': //실패 메시지
                    MessageBox.Show(message, FAIL_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }

        }
    }
}
