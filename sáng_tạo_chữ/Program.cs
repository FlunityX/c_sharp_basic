using System;

namespace LanguageConversion
{
    /* Dr. Patel đang học tiếng Anh, chợt trong đầu nảy ra một ý tưởng về một ngôn ngữ cho riêng bản thân mình, Dr. Patel đã làm như sau.

   Trong ngôn ngữ tiếng anh gồm các phụ âm và các nguyên âm, nguyên âm gồm các ký tự a, u, o, e và i, còn lại là phụ âm. Ngôn ngữ mới của Patel sẽ được chuyển từ tiếng Anh sang bằng cách tất cả các chữ cái thuộc nguyên âm sẽ đều nhân đôi ký tự của chúng.

   Ví dụ: chuỗi ký tự ehlo finalist sẽ được chuyển thành eehloo fiinaaliist.

   Dr. Patel đang tạo dựng từ điển nên cần một chương trình tốt để giúp việc chuyển đổi ngôn ngữ dễ dàng hơn. Cho một chuỗi ký tự 

   có độ dài 

   là chuỗi ký tự trong ngôn ngữ của Dr. Patel, hãy viết chương trình chuyển ngôn ngữ ấy về tiếng Anh.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap tu cua patel");
            string patelLanguage = Console.ReadLine();
            string englishLanguage = patelLanguage.Replace("oo", "o").Replace("ii", "i").Replace("aa", "a").Replace("uu", "u").Replace("ee", "e");
            Console.WriteLine(englishLanguage);
            Console.ReadLine();
        }
    }
}