# 17 - Vin Fletcher's Arrows (Vin's Trouble & Properties)

## Kitaptaki Görev (Challenge)
**Level 18, 19, 20 - Classes, Information Hiding & Properties:** Ok ustası Vin Fletcher için bir `Arrow` sınıfı tasarlamak:
- Ok ucu (`Steel = 10`, `Wood = 3`, `Obsidian = 5` altın), tüy tipi (`Plastic = 10`, `TurkeyFeathers = 5`, `GooseFeathers = 3` altın) ve gövde uzunluğu (`60-100 cm` arası, her cm `0.05` altın) bilgilerini tutmak.
- Alanları kapsüllemek (`private` / `private set`) ve `GetCost()` metoduyla okun toplam maliyetini hesaplamak.

## Nasıl Yaptım?
- `ArrowHeadTypeEnum` ve `FletchingTypeEnum` sabitlerine doğrudan altın maliyetlerini (`int` değerlerini) atadım; böylece `GetCost()` içinde ekstra `switch` yazmadan `(int)ArrowHeadType` ile maliyeti doğrudan aldım.
- `ShaftLength` property'sinin `set` bloğunda uzunluğun `MinShaftLength` (`60`) ile `MaxShaftLength` (`100`) arasında olup olmadığını kontrol ettim, sınır dışındaysa `ArgumentOutOfRangeException` fırlattım.
- Ayrıca minimum gövde uzunluğunu dinamik olarak güncelleyebilmek için `static void ChangeMinShaftLenght(int newMinShaftLength)` metodunu ekledim.
