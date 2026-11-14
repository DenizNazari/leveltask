# 06 - Repairing the Clocktower

## Kitaptaki Görev (Challenge)
**Level 9 - Decision Making:** Consolas Saat Kulesi'ni tamir etmek için kullanıcıdan bir sayı alıp, sayı **çift** ise ekrana `"tick"`, **tek** ise `"tock"` yazdırmak.

## Nasıl Yaptım?
- Kullanıcıdan alınan tam sayının `2` ile bölümünden kalanı (`clock % 2 == 0`) kontrol ettim.
- Kalan `0` ise sayı çifttir diyerek `"tick"`, değilse `else` bloğunda `"tock"` yazdırdım.
