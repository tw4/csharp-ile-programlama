// Kod 5.5 — Parantez niyeti açıklar
// Operatör Önceliği ve Birleşme Yönü

// Ne demek istediği belirsiz:
if (yas > 18 && ehliyetVar || ozelIzin) { }

// Niyet açık:
if ((yas > 18 && ehliyetVar) || ozelIzin) { }
