# XML Address Book 📒

A simple address book that saves and loads contacts using XML serialization in C#.

> 🇹🇷 C# ile XML serileştirme kullanan basit bir adres defteri (kişileri kaydeder ve yükler).

---

## What does it do? / Ne yapar?

It saves a contact (name, phone, email) to XML, and loads it back.
Like packing items into a suitcase and unpacking them later.

> 🇹🇷 Bir kişiyi (ad, telefon, email) XML'e kaydeder ve geri yükler.
> Eşyaları bir bavula koyup sonra çıkarmak gibi.

---

## How does it work? / Nasıl çalışır?

```csharp
var manager = new AddressBookManager();
var contact = new Contact { Name = "Meryem", Phone = "555-1234", Email = "meryem@example.com" };

string xml = manager.Save(contact);        // Serialize: object -> XML (save)
Contact? loaded = manager.Load(xml);       // Deserialize: XML -> object (load)
```

- **Save** = Serialize = object to XML (packing the suitcase)
- **Load** = Deserialize = XML to object (unpacking the suitcase)

> 🇹🇷
> - **Save (Kaydet)** = Serialize = nesne → XML (bavulu doldurmak)
> - **Load (Yükle)** = Deserialize = XML → nesne (bavulu boşaltmak)

---

## What did I use? / Ne kullandım?

- **C# / .NET 9**
- **System.Xml.Serialization** — XmlSerializer
- **XML attributes** — [XmlElement] to name XML elements
- **NUnit** — for tests / testler için

---

## Tests / Testler

The test saves a contact, loads it back, and checks the data is the same.

> 🇹🇷 Test bir kişiyi kaydeder, geri yükler ve verinin aynı olduğunu kontrol eder.

```bash
dotnet test
```

---

## JSON vs XML

This is the XML version of serialization. The logic is the same as JSON, only the format and tools differ.

> 🇹🇷 Bu, serileştirmenin XML versiyonu. Mantık JSON ile aynı, sadece format ve araçlar farklı.

| | JSON | XML |
|--|------|-----|
| Format | `{ }` | `< >` |
| Tool | JsonSerializer | XmlSerializer |
| Attribute | [JsonPropertyName] | [XmlElement] |

Both do the same job: save an object as text, then load it back.

> 🇹🇷 İkisi de aynı işi yapar: bir nesneyi metin olarak kaydet, sonra geri yükle.
