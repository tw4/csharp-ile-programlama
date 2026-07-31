// Kod 18.4 — ÖNCE — her şeyi yapan sınıf (SRP ihlali)
// Örnek Vaka: Kötü Tasarımın Yeniden Düzenlenmesi

public class SiparisYonetici
{
    public void SiparisOlustur(Siparis s)
    {
        if (s.Tutar <= 0) throw new Exception("Hatalı tutar");   // doğrulama
        using var conn = new SqlConnection("Server=...");        // veri erişimi
        conn.Execute("INSERT INTO Siparisler ...", s);
        new SmtpClient().Send("...", s.Eposta, "Siparişiniz alındı"); // bildirim
        File.AppendAllText("log.txt", $"{DateTime.Now}: sipariş");    // günlükleme
    }
}
