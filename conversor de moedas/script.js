document.getElementById("convertBtn").addEventListener("click", () => {
  const baseCurrency = "USD";
  const targetCurrency = "BRL";
  const mockData = { rates: { BRL: 5.25 } }; // Dados fictícios

  document.getElementById(
    "currencyResult"
  ).innerText = `1 ${baseCurrency} = ${mockData.rates[targetCurrency]} ${targetCurrency}`;
});
