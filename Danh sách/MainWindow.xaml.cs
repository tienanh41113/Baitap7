using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace danhsach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int dem = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            List<Student> studentList = new List<Student>();
            // Nhập tên sinh viên thứ nhất
            studentList.Add(new Student("Minh"));
            // Nhập tên sinh viên thứ hai
            studentList.Add(new Student("Hoa"));
            // Nhập tên sinh viên thứ ba
            studentList.Add(new Student("Dung"));
            //Hiển thị thông tin các sinh viên trong ListBox
            // với thuộc tính Name là lst
            foreach (Student st in studentList)
            {
                dem += 1;
                lst_stt.Items.Add(dem.ToString());
                lst_ten.Items.Add(st.StudentName);
            }
        }
    }
}
