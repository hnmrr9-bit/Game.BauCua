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