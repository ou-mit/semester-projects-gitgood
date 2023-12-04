async function getQuote() {
    let textBox = document.getElementById("quote-text");
    const api_url = "http://localhost:3000/getQuote";

    try {
        const response = await fetch(api_url);
      const data = await response.json();
      const quoteText = data[0].q;
      console.log(quoteText);

      // Update HTML content with the fetched quote
      textBox.innerHTML = quoteText;
    } 
    catch (error) {
      console.error('Error fetching quote:', error);
      const quoteContainer = document.getElementById('quote-text');
      quoteContainer.textContent = 'Failed to fetch a quote';
    }
  }

