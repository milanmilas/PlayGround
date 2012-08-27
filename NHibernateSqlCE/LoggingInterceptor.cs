using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.SqlCommand;

namespace NHibernateSqlCE
{
    public class LoggingInterceptor : EmptyInterceptor
    {
        private RichTextBox txtBx;

        public LoggingInterceptor(RichTextBox rchTxtBx) : base()
        {
            txtBx = rchTxtBx;
        }

        public override SqlString OnPrepareStatement(SqlString sql)
        {
            if (txtBx != null)
            {
                txtBx.AppendText("\n"+sql.ToString());
            }
            Debug.WriteLine(sql);

            return sql;
        }
    }
}
