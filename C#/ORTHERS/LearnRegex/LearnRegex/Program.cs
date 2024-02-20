// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;
/*
 * ^ - được sử dụng để gắn một biểu thức chính quy ở đầu chuỗi. Nó khớp với bất kỳ chuỗi nào mà bắt đầu bằng mẫu được chỉ định
 * [] - được sử dụng để định nghĩa một lớp ký tự (character class). Lớp ký tự này khớp với bất kỳ ký tự nào trong nó
 * () - tđược sử dụng để tạo nhóm ký tự (capturing group). Nhóm ký tự này cho phép bạn áp dụng các toán tử hoặc lặp lại cho một phần cụ thể của biểu thức
 * . - khớp với bất kỳ ký tự nào (trừ ký tự xuống dòng \n). Nó thường được sử dụng để biểu diễn bất kỳ ký tự đơn nào trong một chuỗi
 * ? - khớp với 0 hoặc 1 lần xuất hiện của ký tự hoặc nhóm ký tự trước đó trong biểu thức.
 * \ - được sử dụng như một ký tự thoát (escape character). Nó làm cho ký tự đặc biệt mất đi sự đặc biệt của nó và trở thành một ký tự thông thường
 * + - được sử dụng để chỉ định rằng một ký tự hoặc một nhóm ký tự trước đó phải xuất hiện ít nhất một lần. Nó biểu thị một mẫu có thể xuất hiện một hoặc nhiều lần
 * \n - được sử dụng để khớp với ký tự xuống dòng (newline), nó sẽ chỉ khớp với ký tự xuống dòng.
 * \d - được sử dụng để khớp với bất kỳ chữ số nào (digit). Nó tương đương với bất kỳ ký tự số nào từ 0 đến 9
 * \s - là một ký hiệu sử dụng để khớp với bất kỳ ký tự trắng nào trong chuỗi. Ký tự trắng bao gồm khoảng trắng (space), tab (\t), xuống dòng (\n), và các ký tự trắng khác.
 * (x|y) - sử dụng ký hiệu | để biểu thị lựa chọn giữa x hoặc y. Nó khớp với chuỗi có thể chứa hoặc x hoặc y
 * $ - được sử dụng để gắn một biểu thức chính quy ở cuối chuỗi. Nó khớp với bất kỳ chuỗi nào mà kết thúc bằng mẫu được chỉ định
 */

string pattern = @"|Tim"; //Tìm trong chuỗi ký có các ký tự trùng với "Tim", không phân biệt chữ hoa chữ thường
string pattern1 = @"\sTim\s"; //Tìm trong chuỗi các ký tự trùng với " Tim "
string pattern2 = @"Tim"; //Tìm trong chuỗi ký có các ký tự trùng với "Tim", có phân biệt chữ hoa chữ thường
string pattern3 = @"^Tim";//Tìm trong chuỗi các ký tự bắt đau62 từ "Tim"
string pattern4 = @"(\s|^)Tim\s";//Tìm trong chuỗi có ký tự trùng với "Tim " hoặc " Tim "
string pattern5 = @"(\s|^)Tim(\s|$)";//Tìm trong chuỗi có ký tự trùng với "Tim" kèm điều kiện ký tự bắt đầu là " " hoặc "" và kết thúc là " " và ""

//Regex giống như Excel, ghép các biểu thức Regex lại để tạo thành 1 chuỗi biểu thức có nghĩa


string input1 = "Tim Corey";
string input2 = "Timothy Corey";
string input3 = "Sometime";
string input4 = "I Am Tim Corey";
Console.WriteLine($"Tim Corey: {Regex.IsMatch(input1, pattern5)}"); 
Console.WriteLine($"Timothy Corey: {Regex.IsMatch(input2, pattern5)}");
Console.WriteLine($"Sometime: {Regex.IsMatch(input3, pattern5)}");
Console.WriteLine($"I Am Tim Corey: {Regex.IsMatch(input4, pattern5)}");

