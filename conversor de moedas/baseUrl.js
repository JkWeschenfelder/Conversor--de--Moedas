const baseUrl = "https://localhost:5001/api/data";
document.getElementById("convertBtn").addEventListener("click", async () => {
  const baseCurrency = document.getElementById("baseCurrency").value;
  const targetCurrency = document.getElementById("targetCurrency").value;

  const response = await fetch(
    `${baseUrl}/currency?baseCurrency=${baseCurrency}&targetCurrency=${targetCurrency}`
  );
  const data = await response.json();
  document.getElementById(
    "currencyResult"
  ).innerText = `1 ${baseCurrency} = ${data.rates[targetCurrency]} ${targetCurrency}`;
});
document.getElementById("weatherBtn").addEventListener("click", async () => {
  const city = document.getElementById("city").value;

  const response = await fetch(`${baseUrl}/weather?city=${city}`);
  const data = await response.json();
  document.getElementById(
    "weatherResult"
  ).innerText = `Temperatura em ${city}: ${data.main.temp}°C, ${data.weather[0].description}`;
});
