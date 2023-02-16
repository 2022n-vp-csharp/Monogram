# Monogram
## Teszt vezérelt fejlesztés

A *Monogram* osztályban lévő **Kepzes** függvénynek 2 paramétere van, 1 név és egy bool típusú. Ha a név egy magyar, akkor igaz, ha nem akkor pedig hamis értékű.

A függvény célja, hogy visszaadja a monogramot helyes formában az alábbi szabályok szerint:
* Ha a név *dr.* vagy bármilyen ponttal végződő előtaggal rendelkezik, akkor az marad.
* Ha névben kettős betű szerepel, pl. 'ty' vagy 'sz', akkor az lesz a monogram része.
* A vezetéknevekben szereplő kötőjelet is vegye figyelembe.
* Több vezeték vagy keresztnevet is kezelnie kell.

Fejezze be a *Kepzes* függvényt a megadott szabályok alapján. Használja a **MonogramTests** egységtesztet a helyes működés ellenőrzéséhez.