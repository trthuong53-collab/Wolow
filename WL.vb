<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Web Phim Đơn Giản</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: linear-gradient(135deg, #1a1a2e 0%, #16213e 100%);
            color: #fff;
            min-height: 100vh;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        header {
            text-align: center;
            padding: 30px 0;
            background: rgba(0, 0, 0, 0.3);
            border-radius: 15px;
            margin-bottom: 30px;
            position: relative;
        }

        h1 {
            font-size: 2.5rem;
            margin-bottom: 10px;
            background: linear-gradient(45deg, #ff6b6b, #feca57);
            background-clip: text;
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            color: transparent;
        }

        .tagline {
            font-size: 1.1rem;
            opacity: 0.8;
        }

        .player-section {
            background: rgba(0, 0, 0, 0.5);
            border-radius: 15px;
            padding: 20px;
            margin-bottom: 30px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.3);
        }

        .video-container {
            border-radius: 10px;
            overflow: hidden;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
        }

        .movie-info {
            padding: 20px;
            background: rgba(255, 255, 255, 0.1);
            border-radius: 10px;
            margin-top: 20px;
        }

        .movie-title {
            font-size: 1.8rem;
            margin-bottom: 10px;
            color: #feca57;
        }

        .movie-meta {
            display: flex;
            gap: 20px;
            margin-bottom: 15px;
            flex-wrap: wrap;
        }

        .meta-item {
            background: rgba(255, 255, 255, 0.1);
            padding: 5px 15px;
            border-radius: 20px;
            font-size: 0.9rem;
        }

        .movie-description {
            line-height: 1.6;
            opacity: 0.9;
        }

        .controls {
            display: flex;
            gap: 10px;
            margin-top: 15px;
            flex-wrap: wrap;
        }

        .btn {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-weight: bold;
            transition: all 0.3s ease;
        }

        .btn-primary {
            background: #ff6b6b;
            color: white;
        }

        .btn-secondary {
            background: rgba(255, 255, 255, 0.2);
            color: white;
        }

        .btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.3);
        }

        .movie-list {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(200px, 1fr));
            gap: 20px;
            margin-top: 30px;
        }

        .movie-card {
            background: rgba(255, 255, 255, 0.1);
            border-radius: 10px;
            overflow: hidden;
            transition: transform 0.3s ease;
            cursor: pointer;
        }

        .movie-card:hover {
            transform: translateY(-5px);
        }

        .movie-card img {
            width: 100%;
            height: 300px;
            object-fit: cover;
        }

        .movie-card-content {
            padding: 15px;
        }

        .movie-card-title {
            font-size: 1.1rem;
            margin-bottom: 5px;
            color: #feca57;
        }

        footer {
            text-align: center;
            padding: 30px 0;
            margin-top: 50px;
            border-top: 1px solid rgba(255, 255, 255, 0.1);
        }

        /* Thêm style cho search và language selector */
        .search-container {
            display: flex;
            justify-content: center;
            margin: 20px 0;
        }

        #searchInput {
            padding: 10px 15px;
            border: none;
            border-radius: 5px 0 0 5px;
            width: 300px;
            font-size: 1rem;
        }

        #languageSelect {
            padding: 8px 15px;
            border: none;
            border-radius: 5px;
            background: rgba(255, 255, 255, 0.1);
            color: white;
            position: absolute;
            top: 20px;
            right: 20px;
        }

        @media (max-width: 768px) {
            .movie-list {
                grid-template-columns: repeat(auto-fill, minmax(150px, 1fr));
            }
            
            h1 {
                font-size: 2rem;
            }
            
            #languageSelect {
                position: static;
                margin-top: 10px;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <header>
            <h1>🎬 WOLOW</h1>
            <p class="tagline">GL universe</p>
            <select id="languageSelect" onchange="changeLanguage(this.value)">
                <option value="vi">🇻🇳 Tiếng Việt</option>
                <option value="en">🇺🇸 English</option>
            </select>
        </header>

        <div class="search-container">
            <input type="text" id="searchInput" placeholder="Tìm kiếm phim..." onkeyup="searchMovies()">
            <button class="btn btn-primary" onclick="searchMovies()">🔍</button>
        </div>

        <section class="player-section">
            <div class="video-container">
                <div style="position:relative;padding-top:56.25%;">
                    <iframe 
                        src="https://iframe.mediadelivery.net/embed/500657/42e75833-ad7e-407e-a3dd-7f2da1c6bd1a?autoplay=true&loop=false&muted=false&preload=true&responsive=true" 
                        loading="lazy" 
                        style="border:0;position:absolute;top:0;height:100%;width:100%;" 
                        allow="accelerometer;gyroscope;autoplay;encrypted-media;picture-in-picture;" 
                        allowfullscreen="true">
                    </iframe>
                </div>
            </div>

            <div class="movie-info">
                <h2 class="movie-title">Denied Love</h2>
                <div class="movie-meta">
                    <span class="meta-item">⭐ 8.4/10</span>
                    <span class="meta-item">⏱️ 181 phút</span>
                    <span class="meta-item">🎭 LGBT</span>
                    <span class="meta-item">📅 2025</span>
                </div>
                <p class="movie-description">
                    Bộ phim về ...
                </p>
                <div class="controls">
                    <button class="btn btn-primary" onclick="togglePlay()">⏯️ Tạm dừng</button>
                    <button class="btn btn-secondary" onclick="toggleFullscreen()">📺 Toàn màn hình</button>
                    <button class="btn btn-secondary" onclick="shareMovie()">🔗 Chia sẻ</button>
                    <button class="btn btn-secondary favorite-btn" onclick="toggleFavorite()">🤍 Thích</button>
                </div>
            </div>
        </section>

        <section class="movie-list">
            <h2 style="grid-column: 1 / -1; margin-bottom: 20px;">Phim đề xuất</h2>
            <!-- Các movie card sẽ được thêm bằng JavaScript -->
        </section>

        <footer>
            <p>© 2024 WOLOW. Tất cả các quyền được bảo lưu.</p>
            <p style="opacity: 0.7; margin-top: 10px;">Website được tạo cho mục đích học tập và giải trí</p>
        </footer>
    </div>

    <script>
        // Danh sách phim đề xuất
        const recommendedMovies = [
            {
                title: "Love Destiny",
                genre: "Lãng mạn",
                rating: "8.9/10",
                year: "2023",
                image: "https://images.unsplash.com/photo-1518676590629-3dcbd9c5a5c9?w=300&h=450&fit=crop"
            },
            {
                title: "Eternal Sunshine",
                genre: "Tâm lý",
                rating: "8.5/10",
                year: "2024",
                image: "https://images.unsplash.com/photo-1485846234645-a62644f84728?w=300&h=450&fit=crop"
            },
            {
                title: "Midnight Rain",
                genre: "Kịch tính",
                rating: "8.7/10",
                year: "2023",
                image: "https://images.unsplash.com/photo-1535016120720-40c646be5580?w=300&h=450&fit=crop"
            },
            {
                title: "Starlight Journey",
                genre: "Phiêu lưu",
                rating: "8.3/10",
                year: "2024",
                image: "https://images.unsplash.com/photo-1440404653325-ab127d49abc1?w=300&h=450&fit=crop"
            }
        ];

        // Hiển thị danh sách phim đề xuất
        function renderMovieList() {
            const movieList = document.querySelector('.movie-list');
            movieList.innerHTML = '<h2 style="grid-column: 1 / -1; margin-bottom: 20px;">Phim đề xuất</h2>';
            
            recommendedMovies.forEach(movie => {
                const movieCard = document.createElement('div');
                movieCard.className = 'movie-card';
                movieCard.innerHTML = `
                    <img src="${movie.image}" alt="${movie.title}" onerror="this.src='https://via.placeholder.com/300x450/333/fff?text=Poster'">
                    <div class="movie-card-content">
                        <h3 class="movie-card-title">${movie.title}</h3>
                        <p>⭐ ${movie.rating} | 🎭 ${movie.genre}</p>
                        <p>📅 ${movie.year}</p>
                    </div>
                `;
                movieList.appendChild(movieCard);
            });
        }

        // Các hàm điều khiển video
        function togglePlay() {
            const btn = document.querySelector('.btn-primary');
            btn.textContent = btn.textContent.includes('Tạm dừng') ? '▶️ Phát' : '⏸️ Tạm dừng';
        }

        function toggleFullscreen() {
            const iframe = document.querySelector('iframe');
            if (iframe.requestFullscreen) {
                iframe.requestFullscreen();
            } else if (iframe.webkitRequestFullscreen) {
                iframe.webkitRequestFullscreen();
            } else if (iframe.msRequestFullscreen) {
                iframe.msRequestFullscreen();
            }
        }

        function shareMovie() {
            if (navigator.share) {
                navigator.share({
                    title: 'Denied Low',
                    text: 'Đang xem Denied Low trên WOLOW',
                    url: window.location.href
                });
            } else {
                alert('Chia sẻ: ' + window.location.href);
            }
        }

        function toggleFavorite() {
            const heartBtn = document.querySelector('.favorite-btn');
            heartBtn.classList.toggle('active');
            heartBtn.textContent = heartBtn.classList.contains('active') ? '❤️ Đã thích' : '🤍 Thích';
        }

        function searchMovies() {
            const searchTerm = document.getElementById('searchInput').value.toLowerCase();
            const filteredMovies = recommendedMovies.filter(movie => 
                movie.title.toLowerCase().includes(searchTerm) ||
                movie.genre.toLowerCase().includes(searchTerm)
            );
            
            const movieList = document.querySelector('.movie-list');
            movieList.innerHTML = '<h2 style="grid-column: 1 / -1; margin-bottom: 20px;">Kết quả tìm kiếm</h2>';
            
            if (filteredMovies.length === 0) {
                movieList.innerHTML += '<p style="grid-column: 1 / -1; text-align: center;">Không tìm thấy phim phù hợp</p>';
                return;
            }
            
            filteredMovies.forEach(movie => {
                const movieCard = document.createElement('div');
                movieCard.className = 'movie-card';
                movieCard.innerHTML = `
                    <img src="${movie.image}" alt="${movie.title}">
                    <div class="movie-card-content">
                        <h3 class="movie-card-title">${movie.title}</h3>
                        <p>⭐ ${movie.rating} | 🎭 ${movie.genre}</p>
                        <p>📅 ${movie.year}</p>
                    </div>
                `;
                movieList.appendChild(movieCard);
            });
        }

        function changeLanguage(lang) {
            // Có thể thêm tính năng đa ngôn ngữ ở đây
            alert('Đã chuyển ngôn ngữ: ' + (lang === 'vi' ? 'Tiếng Việt' : 'English'));
        }

        // Khởi chạy khi trang load
        document.addEventListener('DOMContentLoaded', function() {
            renderMovieList();
        });
    </script>
</body>
</html>