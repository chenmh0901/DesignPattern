using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DataFacade
    {
        private DataReader reader;
        private DataShow show;
        private DataAnalyze analyze;
        public DataFacade()
        {
            reader = new DataReader();
            show = new DataShow();
            analyze = new DataAnalyze();
        }
        public void DataAnalyzeAndShow()
        {
            reader.Read();
            analyze.Analyze();
            show.Show();
        }
    }
}
