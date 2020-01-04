using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCBCore.Base
{
    public class HtmlPager
    {
        /// <summary>
        /// Phân trang cho gridView
        /// </summary>
        /// <param name="strPathPage">Tiền tố trước page. Có dạng #parram1=value&...</param>
        /// <param name="intCurrentPage">Trang hiện tại</param>
        /// <param name="intRowPerPage">SỐ bản ghi trên 1 trang</param>
        /// <param name="intTotalRecord">Tổng số bản ghi</param>
        /// <returns>Mã html phân trang</returns>
        public static string getPage(string strPathPage, int intCurrentPage, int intRowPerPage, int intTotalRecord)
        {
            List<int> ltsRowPerpage = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
            if (!ltsRowPerpage.Contains(intRowPerPage))
                ltsRowPerpage.Add(intRowPerPage);
            ltsRowPerpage.Sort();

            int intTotalPage = (intTotalRecord % intRowPerPage == 0) ? intTotalRecord / intRowPerPage : ((intTotalRecord - (intTotalRecord % intRowPerPage)) / intRowPerPage) + 1;
            StringBuilder strBuilder = new StringBuilder();
            if (intTotalRecord > 0)
            {
                strBuilder.Append("<div class=\"bottom-pager\">\r\n");
                strBuilder.Append("    <div class=\"left\">\r\n");
                if (intCurrentPage > 1)
                {
                    strBuilder.AppendFormat("        <a href=\"{0}1&RowPerPage={1}\" class=\"first\" title=\"Trang đầu\"></a>\r\n", strPathPage, intRowPerPage);
                    strBuilder.AppendFormat("        <a href=\"{0}{1}&RowPerPage={2}\" class=\"pre\" title=\"Trang trước\"></a>\r\n", strPathPage, intCurrentPage - 1, intRowPerPage);
                }
                else
                {
                    strBuilder.Append("        <a href=\"javascript:;\" class=\"first-disable\" title=\"Trang đầu\"></a>\r\n");
                    strBuilder.Append("        <a href=\"javascript:;\" class=\"pre-disable\" title=\"Trang trước\"></a>\r\n");
                }
                strBuilder.Append("        <span>Trang</span>\r\n");
                strBuilder.AppendFormat("        <input type=\"text\" name=\"page\" id=\"IP_Page\" value=\"{0}\"  data-link=\"{1}\" />\r\n", intCurrentPage, strPathPage);
                strBuilder.AppendFormat("        <input type=\"hidden\" id=\"Help_TotalPage\" value=\"{0}\" />\r\n", intTotalPage);
                strBuilder.AppendFormat("        <input type=\"hidden\" id=\"Help_RowPerPage\" data-RowPerPage=\"{0}\" />\r\n", intRowPerPage);
                strBuilder.AppendFormat("        <span>/{0}</span>\r\n", intTotalPage);

                if (intCurrentPage < intTotalPage)
                {
                    strBuilder.AppendFormat("        <a href=\"{0}{1}&RowPerPage={2}\" class=\"next\" title=\"Trang tiếp\"></a>\r\n", strPathPage, intCurrentPage + 1, intRowPerPage);
                    strBuilder.AppendFormat("        <a href=\"{0}{1}&RowPerPage={2}\" class=\"last\" title=\"Trang cuối\"></a>\r\n", strPathPage, intTotalPage, intRowPerPage);
                }
                else
                {
                    strBuilder.Append("        <a href=\"javascript:;\" class=\"next-disable\" title=\"Trang tiếp\"></a>\r\n");
                    strBuilder.Append("        <a href=\"javascript:;\" class=\"last-disable\" title=\"Trang cuối\"></a>\r\n");
                }
                strBuilder.Append("    </div>\r\n");
                strBuilder.Append("    <div class=\"right\">\r\n");
                strBuilder.AppendFormat("        <span> Tổng số: {0}</span>", intTotalRecord);
                strBuilder.Append("<span>/</span>");
                strBuilder.Append("<span>Kết quả trên 1 trang:</span>\r\n");
                strBuilder.AppendFormat("        <select name=\"RowPerPage\" id=\"CB_RowPerPage\" data-link=\"{0}1\">\r\n", strPathPage);
                foreach (var item in ltsRowPerpage)
                {
                    strBuilder.AppendFormat("            <option value=\"{0}\"{1}>{2}</option>\r\n", item, (item == intRowPerPage) ? " selected" : "", item);
                }
                strBuilder.Append("        </select>\r\n");

                strBuilder.Append("    </div>\r\n");
                strBuilder.Append("</div>\r\n");
            }
            else
            {
                strBuilder.Append("<div class=\"bottom-pager\"><span>Hiện tại danh sách này chưa có dữ liệu.</span></div>\r\n");
            }
            return strBuilder.ToString();
        }
    }
}
