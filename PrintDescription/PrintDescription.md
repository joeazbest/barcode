# Popis tisku

## Typy EAN kódů

### EAN 13

- má dvě možnosti tisku 35 x 10 a 35.6 x 16.9 (větší rozměr zatím nepoužíváme), rozdíl je jasně viditelný
- 35 x 10 má v levém horním rohu žlutý znak (┌)
- 35.6 x  16.9 nemá v žádném rohu žádnou značku

### EAN 8

- tiskne se vždy na 21 x 8
- má v levém horním rohu žlutý znak (┌)

## Tisk

Pokud dojde některý z předtištěných EANů, postup pro tisk dalšího archu je následující:

1) najít složku EANů / barcodů
    - C:\barcode\PDFBarcode
    ![Slozka](Slozka.png)

1) vyberu EAN, který chci tisknout, jednotlivé EANy jsou pojmenovány dle svého čísla
    ![Cislo](Soubor.png)

1) identifikuji papír
    - EAN8
        - 21 x 8
    - EAN13
        - 35 x 10

1) vložím správný papír do tiskárny
    - pokud je na tiskovém papíru žlutá značka (┌), tak tato žlutá značka (┌) musí být v podavači tiskárny vždy vlevo vzadu
    - vždy se ujistím, že papír je správně vložený

1) PDF tisk
    - otevřu soubor v Edge prohlížeči na PDF (pokud nastavení nikdo nezměnil měl by to být defaultní prohlížeč v PC)
    ![Edge](Edge.png)

    - otevřu další nastavení
    ![DalsiNastaveni](DalsiNastaveni.png)

    - v rámci tisku nastavím **Skutečná velikost**. Nebude probíhat žádné zmenšování nebo zvětšování.
    ![SkutecnaVelikost](SkutecnaVelikost.png)

    - vytisknu -> hotovo :-)

