const express = require('express');

const app = express();
const PORT = 3000;

// Set up a route to proxy the request to the API
app.get('/getQuote', async (req, res) => {
  try {
    const fetch = await import('node-fetch');
    const api_url = 'https://zenquotes.io/api/quotes/random?15966594025e9de808e32270e5164e3d';
    const response = await fetch.default(api_url); // Use .default with fetch
    const data = await response.json();

    res.setHeader('Access-Control-Allow-Origin', '*');
    res.json(data);
  } catch (error) {
    console.error('Error fetching quote:', error);
    res.status(500).json({ error: 'Failed to fetch a quote' });
  }
});

app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});
