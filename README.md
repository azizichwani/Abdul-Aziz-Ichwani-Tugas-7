# Abdul-Aziz-Ichwani-Tugas-7
Sample Game for practicing game optimization (reduce draw call, object pooling, resource load)

- Audio Source disimpan dalam bentuk prefab dan kemudian dilakukan Resources.Load dalam list AudioManager, ketika memilih play game with audio maka hanya audio yang indexnya terpilih secara random akan di load di scene selanjutnya sedangkan BGM yang lain dilakukan Resources.UnloadUnusedAssets agar tidak ikut masuk ke scene selanjutnya

- Sprite yang awalnya masih terpisah antara button yang ada didalam folder sprite digabungkan menjadi satu sprite atlas yang berisi seluruh sprite button yang ada didalam asset, sehingga berkurang menjadi hanya sekali sekaligus dalam dua button 

- Untuk spawn object dilakukan object pooling sehingga object didalam game tidak menambah secara terus menerus, melainkan digantikan dengan object yang sudah disimpan sebelumnya didalam list

- dilakukan metode Static Batching pada asset yang ada didalam scene sehingga dapat mengurangi batches yang awalnya 3000 menjadi 600
