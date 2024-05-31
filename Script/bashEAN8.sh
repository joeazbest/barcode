echo "Start"

for FILE in ../PDFBarcode/EAN8/*.html; do
  echo "jsem tu"

  if [ -f "$FILE" ]; then
    echo "Upravuji soubor: $FILE"
    # Uložit nový obsah do dočasného souboru
  fi
done

echo "konec"

read -p "Stiskněte Enter pro ukončení..."

