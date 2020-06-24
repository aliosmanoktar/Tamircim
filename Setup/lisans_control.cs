using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup
{
    public partial class lisans_control : UserControl
    {
        Form1 form;
        public lisans_control(Form1 form1)
        {
            this.form = form1;
            InitializeComponent();
        }
        string veri= "Cats Yazılım Tamircim Programı\n" +
"Yazılım Ürünleri Kullanma Lisansı ve Garanti Sözleşmesi\n" +
"1. SÖZLEŞMENİN KONUSU\n" +
"Bu sözleşme satın alınan yazılım ürününün, uygun konfigürasyonlu bir bilgisayarda kullanımına ilişkin lisans şartlarını kapsar.\n" +
"2. KULLANIM LİSANSININ KAPSAMI\n" +
"2.1. GENEL HÜKÜMLER\n" +
"2.1.1. Kullanım lisansı, yazılımın bilgisayara yüklenmesi, çalıştırılması, kullanılması görüntülenmesi, depolanması ve yedeğinin alınması haklarını kapsar.\n" +
"2.1.2. MÜŞTERİ, yazılımı ödünç vermek, kiralamak gibi bedelli veya bedelsiz hiçbir biçimde üçüncü kişilerin yararına sunamaz, kullandıramaz.\n" +
"2.1.3. Münhasır olmayan bu hakkın dışında kalan tüm diğer telif ve mülkiyet hakları Cats Yazılım üzerinde kalır ve bu sözleşme kapsamı dışındadır.\n" +
"2.1.4. Bu sözleşmeden doğacak hak ve yükümlülükler hiçbir şekilde üçüncü kişilere devredilemez.\n" +
"\n" +
"2.2. TEK BİLGİSAYARDA KULLANIM\n" +
"MÜŞTERİ (çok kullanıcı lisanslı paketler haricinde) yazılımı her ne şartta olursa olsun, aynı anda iki veya daha fazla bilgisayarın sabit diskine kuramaz. MÜŞTERİ yazılımları aynı sabit diske birden fazla kopya olarak yükleyip, farklı işlemler için kullanamaz.\n" +
"\n" +
"3. HATALI ÜRÜN VE KULLANICININ HAKLARI\n" +
"Arızalı çıkan yazılımların kayıtlı olduğu disket/CD-ROM ve yazılı doküman, fatura tarihinden itibaren en geç 7 gün içerisinde iade edildiği takdirde yenisi ile değiştirilir veya bedeli karşılığında iade alınır yada arızalı malzemenin bedeli satış fiyatından düşülür. MÜŞTERİ bu hakkını, faturası ile birlikte yazılımı satın aldığı Cats Yazılım Yetkili Satıcısına başvurarak kullanılır. MÜŞTERİ, belirtilen süreden sonra hatalı mal itirazında bulunamaz.\n" +
"\n" +
"4. SORUMLULUKLARIN SINIRLANMASI\n" +
"4.1. Cats Yazılım yazılım ürünlerinin dokümantasyonlarıyla ve matbu ve/veya manyetik ortamda sağlanan dokümantasyonlarında tanımlanan işlevleri en iyi şekilde yerine getirmesi için gerekli azami özeni göstermektedir. Cats Yazılım, yazılımlarının tümüyle kusursuz, hatasız, mükemmel olduğu ve kullanıcının genel ve/veya özel ihtiyaçlarını tamamen karşılayacağı şekilde bir iddia ve taahhütte bulunmaz.\n" +
"4.2. Cats Yazılım, donanım veya işletim sistemi arızasından, telif hakları Cats Yazılım'a ait olmayan veri tabanı yazılımından, iletişim ağı (network) tasarım ve bağlantı hatalarından voltaj dalgalanması ve elektrik kesilmesinden virüs bulaşmasından ve benzer çevresel faktörler ve kullanıcı hatalarından kaynaklanacak bilgi ve yazılım kayıplarından sorumlu tutulamaz.\n" +
"4.3. Cats Yazılım, manyetik ortamda saklanan bilgileri garanti edemez. Yazılımların kullanılması ile oluşan bilgilerin düzenli olarak yedeğinin alınmasından her zaman kullanıcı sorumludur.\n" +
"4.4. MÜŞTERİ, Kullanım lisansını aldığı yazılımları, yazılım dokümantasyonlarında belirtilen asgari teknik özelliklere sahip bir donanım üzerinde kullanacağını ve gerekli bu donanımı kendisinin temin edeceğini, Cats Yazılım'ın yazılım-donanım uyuşmazlığı ile ilgili hiçbir maddi ve hukuki sorumluluğunun bulunmadığını, Cats Yazılım'ın sorumluluk sınırının Sözleşme konusu yazılım ürünleri için kullanım lisansı verilmesi ile sınırlı olduğunu kabul eder.\n" +
"4.5. Cats Yazılım, yazılım ürünlerinin yanlış kullanımından veya hukuka aykırı işlerde veya kanuna aykırı olarak kullanılmasından dolayı ortaya çıkabilecek maddi, manevi,hukuki ve mali sonuçlardan kazanç veya kayıplardan hiç bir biçimde sorumlu değildir.\n" +
"4.6. Taraflar, doğrudan veya dolaylı olarak bu Sözleşmeden kaynaklanacak kendi aralarındaki tüm ihtilaflarda diğer taraftan talep edebilecekleri her türlü tazminat miktarının (mali sorumluluğun) MÜŞTERİ' nin lisans bedeli olarak ödediği miktarla sınırlı olduğunu kabul etmişlerdir.\n" +
"4.7. Fikir ve Sanat Eserleri Kanunu'nu ihlal eden eylemler saklı kalmak kaydıyla, tazminat talebini haklı kılan herhangi bir durumda Cats Yazılım, MÜŞTERİ' den sadece bu Sözleşmenin toplam bedeli kadar tazminat talep edebilir. MÜŞTERİ açısından herhangi bir nedenle yazılım lisansını iade hakkı doğduğunda, yazılımlar için ödediği lisans bedeli dışında herhangi bir nam altında tazminat talebinde bulunmamayı peşinen kabul ve taahhüt eder. Taraflar, bu şekilde karşılıklı olarak sınırlanmışlardır.\n" +
"4.8. Cats Yazılım, MÜŞTERİ' nin yazılımı kullanmaya başladığı (ilk kez şifre aldığı) tarihten itibaren 3 (üç) ay süre ile müşteriye eposta desteğini ücretsiz olarak verir. Bu sürenin bitiminden sonra MÜŞTERİ dilerse Cats Yazılım'dan ücret karşılığı, hizmet ve destek satın alabilir.\n" +
"4.9. Taraflar, Cats Yazılım 'un bu Sözleşme konusu yazılımlar üzerinde MÜŞTERİ' ye yalnızca \"Kullanım Lisansı\" verdiğini, MÜŞTERİ' nin üretkenlik, iş gelir ve/veya kar kaybı, yazılımın yerelleştirilmesi, yazılımın ve verilerin kullanılması gibi nedenlerle ortaya çıkabilecek herhangi bir kayıp veya zarar konularında Cats Yazılım ' un hiçbir sorumluluğunun olmadığını bunları tazmin etmekle yükümlü olmayacağını peşinen kabul etmişlerdir. Taraflar arasında yetkili kişileri imzasını taşıyan ek bir yazılı sözleşme olmaksızın, hiç bir şirket elemanının sözlü ve yazılı beyanı mektup, e-posta, faks metni, servis formu ve benzeri muhaberat, özel bir taahhüt olarak kabul edilmeyecektir.\n"+
"\n"+
"5. YAZILIM TELİF HAKLARI\n"+
"5.1. Yazılım ve dokümantasyonun telif hakları 5846 Sayılı Fikir ve Sanat Eserleri Kanunu, Türk Ceza Kanunu, Markalar Kanunu, Markaların Korunması Hakkında K.H.K. Türk Ticaret Kanunu ve muhtelif Vergi Kanunu hükümleri ile koruma altına alınmıştır. Kullanım lisans hakkı dışında kalan hukuka aykırı kopya eylemi ve işlemler eylemin nevine göre cezai yaptırıma sahiptir.\n"+
"5.2. Cats Yazılım tarafından temin edilen uygulama yazılımlarının üzerinde çalıştığı ve telif hakları Cats Yazılım 'a ait olmayan veri tabanı ve iletişim ağı (network) yazılımlarının geçerli ve yeterli kullanım lisansına sahip olunup olunmamasından kesinlikle MÜŞTERİ sorumludur.\n"+
"\n"+
"6. YAZILIM ÜRÜNLERİNİN TESLİMİNE İLİŞKİN KOŞULLAR\n"+
"MÜŞTERİ bu Sözleşme ile kullanım lisansını aldığı yazılım ürünlerinin adresine teslimini kabul etmiştir. Bu adrese yapılan teslimat geçerli teslimat sayılır. MÜŞTERİ bu adrese yapılan teslimlerde teslimatın kendisine yapılmadığı, firma elemanına yapılmadığı gibi itirazlarda bulunmayacağını ve bu hakkından peşinen feragat ettiğini kabul etmiştir.\n"+
"\n"+
"7. DİSKET, CD-ROM, YAZILI DOKÜMAN (DOKÜMANTASYON)\n"+
"Sözleşme konusu yazılım ürünlerinin içinde olduğu disket/CD-ROM ve birlikte verilen dokümanın telif hakları da Cats Yazılım'a aittir. Dokümanların değiştirilmesi, başka amaçlarla kullanılması, kopya edilmesi çoğaltılması telif haklarının ihlalidir.\n"+
"\n"+
"8. SÜRÜM/VERSİYON DEĞİŞİMİ VE BAKIM\n"+
"Cats Yazılım önceden haber vermeksizin yazılımlarında ve yazılı dokümanlarında değişiklikler yapma, yazılım ürünlerinin yeni versiyon ve sürümlerini çıkarma hakkına sahiptir, MÜŞTERİ bu yeni versiyon veya sürümü ve yeni yazılı dokümanları ancak fiyat listelerinde belirtilecek olan \"yeni versiyona/sürüme geçiş(upgrade)\" bedelini ödeyerek yeni bir lisans almakla elde edebilir. Cats Yazılım isterse upgrade'leri belli sürelerle ücretsizde yapabilir. Cats Yazılım ayrıca yeni versiyon veya sürümlerin alınması halinde eski versiyon/sürümle girilen veya elde edilen bilgilerin yeni versiyon/sürümle de işlenebileceği güvencesini vermez, Cats Yazılım , geleneksel olarak çıkardığı her yeni versiyon için eski versiyonla işlenmiş verileri yeni versiyona aktarmakta sorumlu değildir.\n"+
"Yeni versiyon veya sürümü çıkan bir yazılımın mevcut versiyon veya sürümü, yeni versiyon veya sürümün çıkış tarihinden itibaren 6 (altı) ay süreyle desteklenir. Ancak mevzuatta meydana gelen değişiklikler ve programın çalışmasıyla ilgili düzeltme ve yenilikler eski sürüm ve versiyonlara uygulanmaz. Altı aylık süre sonunda eski versiyon veya sürüm üretimden kaldırılabilir veya kaldırma hakkını Cats Yazılım saklı tutar. Üretimden kalkan versiyon ve sürümlerin program ve disketleri, dokümantasyonu ve bu yazılımlar için destek hizmeti Cats Yazılım'dan her zaman temin edilemeyebilir. Aksi bir hüküm, taraflar arasında yazılı olarak kararlaştırılmadıkça Cats Yazılım uygulama ürünlerinin üzerinde çalıştığı veri tabanı ve iletişim ağı yazılımlarına destek hizmeti vermek ve bunlardan kaynaklanan sorunlara çözüm getirmek, Cats Yazılım'ın görev ve sorumluluğuna girmez.\n"+
"MÜŞTERİ Sözleşme Özel Hükümlerinde belirtilen hizmetin dışında destek hizmeti isterse bu talebini ücreti karşılığında ayrı bir Bakım Anlaşması yaparak temin edebilir.\n"+
"\n"+
"9. SÖZLEŞMENİN BOZUCU ŞARTLA SONA ERMESİ\n"+
"Aşağıdaki hallerde lisans sözleşmesi başka bir hükme, ihtara, ihbara gerek olmaksızın bozucu şartla kendiliğinden sona erer.\n"+
"9.1. MÜŞTERİ'nin lisans bedelini ödememesi veya eksik ödemesi halinde.\n"+
"9.2. MÜŞTERİ'nin Cats Yazılım'un telif haklarını ihlal etmesi halinde.\n"+
"MÜŞTERİ bu durumda, elinde bulunan yazılım ve dokümantasyonun 7 gün içinde başkaca bir hükme, ihbara, ihtara gerek olmaksızın Cats Yazılım'a teslim etmekle ve bilgisayarlarında yüklü bulunan yazılımın tüm kopyalarını silmekle yükümlüdür.\n"+
"\n"+
"10. DİĞER HÜKÜMLER\n"+
"10.1. Bu sözleşmenin kabulü ile bundan önce taraflar arasında bu yazılım lisansı ile ilgili olarak cereyan etmiş yazılı ve sözlü teklifler, icap ve kabuller, yazılı anlaşmalar, ticari diğer yazışmalar ve taahhütler hükmünü yitirir. Bu Sözleşmeyi tamamlatıcı nitelikte olan Özel Müşteri Sözleşmesi varsa, bu hükmün dışındadır.\n"+
"10.2. Bu sözleşmedeki hükümler ancak karşılıklı olarak imzalanmış ek sözleşmelerle değiştirilebilir. Bunun dışındaki hiçbir beyan ve yazı sözleşmenin tadili anlamına gelmez.\n"+
"10.3. Bu sözleşmeden doğacak anlaşmazlıklarda İzmir icra daireleri ve mahkemeleri yetkilidir. Anlaşmazlıklarda TÜRK Hukuku uygulanır.\n"+
"10.4. Bu sözleşme MÜŞTERİ tarafından kabul edilmiş sayılır.\n";

        private void lisans_control_Load(object sender, EventArgs e)
        {
            text1.Text = veri;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                form.btn_ileri.Enabled = true;
            else form.btn_ileri.Enabled = false;
        }

        private void lisans_control_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                checkBox1.Checked = false;
                form.btn_ileri.Enabled = false;
            }
            else form.btn_ileri.Enabled = true;
        }
    }
}
