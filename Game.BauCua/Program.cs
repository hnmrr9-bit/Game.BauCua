// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Game Bau Cua");
        string[] animals =
        {
            "Bầu",
            "Cua",
            "Tôm",
            "Cá",
            "Gà",
            "Nai"
        };
        int soDu = 1000;
        int tongSoVan = 0;
        int soVanThang = 0;
        int soVanThua = 0;
        int tienThangLonNhat = 0;

        while (soDu > 0)
        {
            Console.WriteLine($"Số dư hiện tại của bạn: {soDu} điểm");
            Console.Write("Bạn có muốn chơi tiếp không? (Nhập 'k' để thoát, hoặc nhấn phím Enter để chơi): ");
            string luaChon = Console.ReadLine();
            if (luaChon.ToLower() == "k")
            {
                break;
            }

            int[] tienCuoc = new int[6];
            int tongCuocTrongVan = 0;
        

        while (true)
            {
                Console.WriteLine("\nDanh sách animals:");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine($"{i + 1}. {animals[i]}");
                }

                Console.WriteLine("0. QUAY XÚC XẮC (Chốt cược)");

                Console.Write("Chọn animals muốn cược (0-6): ");
                int animalss = int.Parse(Console.ReadLine());

                if (animalss == 0)
                {
                    if (tongCuocTrongVan > 0)
                    {
                        break;
                    }
                    else
                    {
                        tongCuocTrongVan++;
                    }
                }

                int chonAnimal = 0;
                if (chonAnimal >= 1 && chonAnimal <= 6)
                {
                    Console.Write($"Nhập số tiền muốn cược vào {animals[chonAnimal - 1]}: ");
                    int soTien = int.Parse(Console.ReadLine());

                    if (soTien <= 0)
                    {
                        Console.WriteLine("Số tiền cược phải lớn hơn 0.");
                    }
                    else if (tongCuocTrongVan + soTien > soDu)
                    {
                        Console.WriteLine(
                            $"LỖI: Tổng tiền cược vượt quá số dư! Bạn chỉ còn {soDu - tongCuocTrongVan} điểm để cược thêm.");
                    }
                    else
                    {
                        tienCuoc[chonAnimal - 1] += soTien;
                        tongCuocTrongVan += soTien;
                        Console.WriteLine(
                            $"=> Đã cược {soTien} vào {animals[animalss - 1]}. Tổng cược: {tongCuocTrongVan}/{soDu}");
                    }
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn từ 0 đến 6.");
                }
            }
            Console.WriteLine("\nĐANG TUNG XÚC XẮC...");
            Random rand = new Random();
            int xucXac1 = rand.Next(0, 6); // Random từ 0 đến 5
            int xucXac2 = rand.Next(0, 6);
            int xucXac3 = rand.Next(0, 6);

            Console.WriteLine($"Kết quả xúc xắc: [ {animals[xucXac1]} ] - [ {animals[xucXac2]} ] - [ {animals[xucXac3]} ]");
            int[] soLanXuatHien = new int[6];
            soLanXuatHien[xucXac1]++;
            soLanXuatHien[xucXac2]++;
            soLanXuatHien[xucXac3]++;

            int tienThangVanNay = 0;
            int tienThuangVanNay = 0;

            for (int i = 0; i < 6; i++)
            {
                if (tienCuoc[i] > 0)
                {
                    if (soLanXuatHien[i] > 0)
                    {
                        int tienThang = tienCuoc[i] * soLanXuatHien[i];
                        tienThangVanNay += tienThang;
                        soDu += tienThang;
                    }
                    else
                    {
                        int tienThuaVanNay = tienCuoc[i];
                        soDu -= tienCuoc[i];
                    }
                }
            }

            void ShowStatistic()
            {
                Console.WriteLine("\n================ BẢNG THỐNG KÊ ================");
                Console.WriteLine($"Tổng số ván đã chơi : {tongSoVan}");
                Console.WriteLine($"Số ván thắng        : {soVanThang}");
                Console.WriteLine($"Số ván thua         : {soVanThua}");
                Console.WriteLine($"Tiền thắng lớn nhất : {tienThangLonNhat} điểm (trong 1 ván)");
                Console.WriteLine($"Số dư cuối cùng     : {soDu} điểm");
                Console.WriteLine("===============================================");
            }
        }
    }
}
    
    
    
    
   


