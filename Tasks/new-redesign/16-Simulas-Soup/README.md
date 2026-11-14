# 16 - Simula's Soup

## Kitaptaki Görev (Challenge)
**Level 17 - Tuples:** Yemek türü (`soup`, `stew`, `gumbo`), ana malzeme (`chicken`, `mushroom`, `carrot`, `potatoes`) ve baharat (`spicy`, `salty`, `sweet`) için üç ayrı `enum` tanımlamak. Kullanıcıdan bu üç seçimi alıp bir **Tuple** içinde birleştirerek `"spicy chicken soup"` formatında ekrana yazdırmak.

## Nasıl Yaptım?
- `FoodTypeEnum`, `FoodManingredientEnum` ve `FoodSeasoningEnum` olmak üzere üç `enum` tanımladım.
- Geriye `(FoodTypeEnum FType, FoodManingredientEnum FMain, FoodSeasoningEnum FSeason)` şeklinde isimlendirilmiş bir **Tuple** döndüren `food()` metodunu yazdım.
- Metot içinde üç girdiyi de `Enum.TryParse` ile doğrulayıp hepsi geçerliyse tuple olarak döndürdüm ve sonucu ekrana yazdırdım.
