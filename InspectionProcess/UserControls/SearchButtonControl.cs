using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InspectionProcess.UserControls
{
    public partial class SearchButtonControl : UserControl
    {
        public SearchButtonControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OnSearchButtonClicked();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            OnResetButtonClicked();
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        /*private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }*/

        public class SearchButtonClickedEventArgs : EventArgs
        {


            /*public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs()
            {

            }*/
        }
        #endregion

        #region ResetButtonClicked event things for C# 3.0
        public event EventHandler<ResetButtonClickedEventArgs> ResetButtonClicked;

        protected virtual void OnResetButtonClicked(ResetButtonClickedEventArgs e)
        {
            if (ResetButtonClicked != null)
                ResetButtonClicked(this, e);
        }

        private ResetButtonClickedEventArgs OnResetButtonClicked()
        {
            ResetButtonClickedEventArgs args = new ResetButtonClickedEventArgs();
            OnResetButtonClicked(args);

            return args;
        }

        /*private ResetButtonClickedEventArgs OnResetButtonClickedForOut()
        {
            ResetButtonClickedEventArgs args = new ResetButtonClickedEventArgs();
            OnResetButtonClicked(args);

            return args;
        }*/

        public class ResetButtonClickedEventArgs : EventArgs
        {


            /*public ResetButtonClickedEventArgs()
            {
            }

            public ResetButtonClickedEventArgs()
            {

            }*/
        }
        #endregion
    }
}
