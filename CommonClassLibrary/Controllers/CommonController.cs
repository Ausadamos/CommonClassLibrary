using BusinessData.Property;
using CommonClassLibrary.Models;
using System;
using System.Windows.Forms;

namespace CommonClassLibrary.Controllers
{
    public class CommonController
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        CommonModel _model = new CommonModel();

        public string getDateTimeNow()
        {
            string result = "";
            try
            {
                _resultData = _model.getDateTimeNow();
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        result = _resultData.ResultOnDb.Rows[0][0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public string getYearNow(int countYear)
        {
            string result = "";
            try
            {
                _resultData = _model.getYearNow(countYear);
                if (_resultData.StatusOnDb == true)
                {
                    if (_resultData.ResultOnDb.Rows.Count > 0)
                    {
                        result = _resultData.ResultOnDb.Rows[0][0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show(_resultData.MessageOnDb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}