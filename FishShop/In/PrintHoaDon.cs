
using FishShop.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Diagnostics;
using FishShop.model;
using FishShop.Controller;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.Globalization;

namespace FishShop.In
{
    internal class PrintHoaDon
    {
       
        
        public static void CreateAndSavePDF(hoadon hoadon, decimal tienmat)
        {
            LoaiCaController loaiCaController = new LoaiCaController();
            List<loaica> loaicaList = new List<loaica>();
            loaicaList = loaiCaController.Load();
            // Tạo một tài liệu PDF mới
            Document document = new Document();
            
            // Đặt đường dẫn lưu trữ PDF vào thư mục chỉ định
            string pdfPath = @"C:\Users\dangt\source\repos\FishShop\FishShop\In\PDF\" + hoadon.getMaHD() + ".pdf";

            string logoPath = @"C:\Users\dangt\source\repos\FishShop\FishShop\bin\Debug\net7.0-windows\img\_d4514919-5200-4775-9501-0d423605b6c0.jpg";

            // Tạo một tệp tin PDF mới
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

            // Mở tài liệu để bắt đầu viết dữ liệu
            document.Open();
            BaseFont bf = BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
            logo.Alignment = Element.ALIGN_CENTER; // Set the alignment of the logo
            logo.ScaleAbsolute(100f, 100f);
            document.Add(logo);

            Paragraph storeInfo = new Paragraph();
            storeInfo.Alignment = Element.ALIGN_CENTER;
            storeInfo.Add(new Chunk("FishShop\n", new iTextSharp.text.Font(bf, 16)));
            storeInfo.Add(new Chunk("Địa chỉ: 11/12A Tân Thới Nhất 12, Quận 12, Tp.HCM\n", font));
            storeInfo.Add(new Chunk("Liên hệ: 0366542543", font));

            document.Add(storeInfo);

            LineSeparator line = new LineSeparator(1f, 100f, BaseColor.BLACK, Element.ALIGN_CENTER, -1);
            document.Add(line);

            Paragraph paragraph = new Paragraph("HÓA ĐƠN", font);
            paragraph.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph);
            document.Add(Chunk.NEWLINE);
            document.Add(new Paragraph("Mã HD: " + hoadon.getMaHD(), font));
            document.Add(new Paragraph("Ngày: " + hoadon.getNgayHD(), font));
            document.Add(new Paragraph("Tên khách hàng: " + hoadon.getTenKH(), font));

            document.Add(Chunk.NEWLINE);

            // Thêm thông tin chi tiết hóa đơn ở đây
            // Khởi tạo bảng với số cột tương ứng
            int numColumns = 4; // Số cột: Tên Cá, Đơn giá, Số lượng, Thành tiền
            PdfPTable table = new PdfPTable(numColumns);

            float[] columnWidths = new float[] { 2f, 1f, 1f, 1f };
            table.SetWidths(columnWidths);
            table.AddCell(new PdfPCell(new Phrase("Tên Cá", font)));
            table.AddCell(new PdfPCell(new Phrase("Đơn giá", font)));
            table.AddCell(new PdfPCell(new Phrase("Số lượng", font)));
            table.AddCell(new PdfPCell(new Phrase("Thành Tiền", font)));
            // Đưa thông tin chi tiết hóa đơn vào bảng
            foreach (ChiTietHoaDon cthd in hoadon.getcthds())
            {
                loaica loaica = loaiCaController.Get(cthd.getMaCa());
                table.AddCell(new PdfPCell(new Phrase(loaica.getFishName(), font)));
                table.AddCell(new PdfPCell(new Phrase(""+cthd.getDonGia(), font)));
                table.AddCell(new PdfPCell(new Phrase(""+cthd.getSoLuong(), font)));
                table.AddCell(new PdfPCell(new Phrase(""+cthd.getDonGia() * cthd.getSoLuong(), font)));
            }

            // Thêm bảng vào tài liệu PDF
            document.Add(table);
            document.Add(Chunk.NEWLINE);

            Paragraph par = new Paragraph();
            Chunk labelChunk = new Chunk("Tổng đơn hàng: ", new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD));

            // Thêm Chunk vào Paragraph
            par.Add(labelChunk);
            Chunk valueChunk = new Chunk(hoadon.CalculateTotal().ToString("C", new CultureInfo("vi-VN")), new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD));

            // Thêm Chunk vào Paragraph và đặt căn phải
            par.Add(valueChunk);
            par.Alignment = Element.ALIGN_RIGHT;

            // Thêm đối tượng Paragraph vào tài liệu PDF
            document.Add(par);
            // Đóng tài liệu PDF
            // Thêm tiền mặt và tiền thối lại vào tài liệu PDF
            document.Add(Chunk.NEWLINE);
            Paragraph tienMatParagraph = new Paragraph("Tiền mặt (VND): " + tienmat.ToString("C", new CultureInfo("vi-VN")), font);
            tienMatParagraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(tienMatParagraph);

            decimal tienThoiLai = tienmat - hoadon.CalculateTotal();
            if (tienThoiLai >= 0)
            {
                Paragraph tienThoiLaiParagraph = new Paragraph("Tiền thối lại (VND): " + tienThoiLai.ToString("C", new CultureInfo("vi-VN")), font);
                tienThoiLaiParagraph.Alignment = Element.ALIGN_RIGHT;
                document.Add(tienThoiLaiParagraph);
                
            }
            else
            {
                Paragraph tienThieuParagraph = new Paragraph("Tiền thiếu (VND): " + Math.Abs(tienThoiLai), font);
                tienThieuParagraph.Alignment = Element.ALIGN_RIGHT;
                document.Add(tienThieuParagraph);
            }

            document.Close();

            string edgeExecutablePath = "C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe";

            Process.Start(edgeExecutablePath, pdfPath);
        }
    }
}
