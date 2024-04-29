using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    public class location
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public location(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public location() { }
        public static List<location> GetLocations()
        {
            List<location> locationList = new List<location>();
            locationList.Add(new location("Q801", "VRMS Quận 8", "Tòa Green River, Khối C, Tầng 02, Số 2225 Phạm Thế Hiển, Phường 6, Quận 8, TP.Hồ Chí Minh"));
            locationList.Add(new location("BT01", "VRMS An Lạc", "539A - 539B đường Kinh Dương Vương (Ngay Vòng xoay An Lạc), khu phố 1, phường An Lạc, quận Bình Tân, TP.Hồ Chí Minh"));
            locationList.Add(new location("CC02", "VRMS Củ Chi 2", "830 Quốc lộ 22, khu phố 8, thị trấn Củ Chi, huyện Củ Chi, TP.Hồ Chí Minh"));
            locationList.Add(new location("Q601", "VRMS Quận 6", "Tầng 2, tòa nhà Nhật Đỉnh Tower, 245 Nguyễn Văn Luông, Phường 11, Quận 6, TP. Hồ Chí Minh"));
            locationList.Add(new location("Q1201", "VRMS Thới An", "109 đường Lê Thị Riêng (Thới An 28), Phường Thới An, Quận 12, Tp.HCM"));
            locationList.Add(new location("Q901", "VRMS Quận 9", "Sài Gòn Villas Hill, 99 Lê Văn Việt, P. Tăng Phú Nhơn A, TP. Thủ Đức, TP. Hồ Chí Minh"));
            locationList.Add(new location("Q801", "VRMS Quận 10", "460 Đường 3 Tháng 2, Phường 12, Quận 10, Tp. Hồ Chí Minh"));
            locationList.Add(new location("QGV01", "VRMS Gò Vấp", "304A Quang Trung, Phường 11, Quận Gò Vấp, (Lầu 2 , Toà nhà TTTM Co.opmart Quang Trung), Thành phố Hồ Chí Minh"));
            locationList.Add(new location("Q801", "VRMS Quận 1", "Tầng 2, Trung tâm thương mại NOWZONE, 235 Nguyễn Văn Cừ, P. Nguyễn Cư Trinh, Quận 1, TP. Hồ Chí Minh"));
            return locationList;
        }

        public static location FindLocation(string targetlocation, List<location> locationList)
        {
            location current = new location();
            foreach (location v in locationList)
            {
                if (v.name.Equals(targetlocation))
                    current = v;
            }
            return current;
        }
    }
}
