API Gateway Örneği (Ocelot)

Bu proje, Ocelot kullanılarak oluşturulmuş basit bir API Gateway örneğini içerir. Amaç, farklı mikro servislerin tek bir giriş noktası üzerinden yönetilmesini, yönlendirilmesini ve istemci tarafında daha tutarlı bir API yapısı sunulmasını sağlamaktır.



Bu uygulamanın amacı:

Farklı portlarda çalışan mikro servisleri tek bir kapıdan erişilebilir hale getirmek

Yönlendirme işlemlerini merkezi olarak yönetmek

İstemcinin karmaşık mikro servis yapısını görmesini engellemek

Temel API Gateway mantığını göstermek

Bu örnekte iki mikro servis bulunur:

Rezervasyon Servisi (/api/res/{id})

İletişim Servisi (/api/contact/{id})

API Gateway bu servislere:

/r/{id} → Rezervasyon servisine yönlendirir

/c/{id} → İletişim servisine yönlendirir

Bu yapı sayesinde:

Servis adresleri gizlenir

İletişim tek noktadan yönetilir

Microservice mimarisi sade ve yönetilebilir olur

Gereken Paketler

API Gateway için gerekli NuGet paketleri:

Ocelot

Ocelot.DependencyInjection

Ocelot.Middleware

Microsoft.Extensions.Configuration.Json

Kullanım

Rezervasyon API'yi çalıştırın (port 5103)

Contact API'yi çalıştırın (port 5107)

API Gateway’i çalıştırın (port 7015)

Gateway üzerinden istekler:

Rezervasyon servisi: https://localhost:7015/r/3

Contact servisi: https://localhost:7015/c/5

Bu istekler içerde ilgili mikro servise yönlendirilir.

