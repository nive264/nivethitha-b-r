body {
  margin: 0;
  font-family: Arial, sans-serif;
  background: linear-gradient(135deg, #001f3f, #005f99);
  color: white;
  min-height: 100vh;
}

/* Navbar */
.navbar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #003366;
  padding: 1rem 2rem;
}
.navbar .logo {
  font-size: 1.5rem;
  font-weight: bold;
}
.navbar .links a {
  margin-left: 1rem;
  text-decoration: none;
  color: white;
  font-weight: bold;
}
.navbar .links a:hover {
  color: #00c3ff;
}

/* Candidate Cards */
.candidates {
  display: flex;
  justify-content: center;
  gap: 20px;
  margin-top: 2rem;
}
.candidate-card {
  background: #004080;
  padding: 20px;
  border-radius: 12px;
  text-align: center;
  box-shadow: 0px 4px 10px rgba(0,0,0,0.3);
}
.candidate-card h2 {
  margin-bottom: 10px;
}
.candidate-card button {
  background: #00c3ff;
  color: white;
  border: none;
  padding: 10px 15px;
  border-radius: 8px;
  cursor: pointer;
  font-weight: bold;
}
.candidate-card button:hover {
  background: #00a0cc;
}

/* Reset Button */
.reset-btn {
  margin-top: 2rem;
  background: #ff4444;
  border: none;
  padding: 12px 20px;
  border-radius: 10px;
  cursor: pointer;
  color: white;
  font-size: 1rem;
}
.reset-btn:hover {
  background: #cc0000;
}

/* Results Page */
.results-page {
  padding: 2rem;
  text-align: center;
}
.result-item {
  margin: 20px 0;
}
.progress-bar {
  background: #002244;
  border-radius: 10px;
  overflow: hidden;
  height: 20px;
  margin-top: 5px;
}
.progress {
  height: 100%;
  background: #00c3ff;
  transition: width 0.5s ease;
}
.leading {
  margin-top: 2rem;
  font-size: 1.5rem;
  color: #ffcc00;
}
