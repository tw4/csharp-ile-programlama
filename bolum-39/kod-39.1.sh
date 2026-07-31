# Kod 39.1 — Günlük Git akışı
# Anlamlı Commit ve Pull Request Yazmak

git switch -c ozellik/siparis-iptali
git add src/Siparis/SiparisServisi.cs
git commit -m "feat(siparis): sipariş iptal akışı eklendi"

git fetch origin
git rebase origin/main
git push -u origin ozellik/siparis-iptali
