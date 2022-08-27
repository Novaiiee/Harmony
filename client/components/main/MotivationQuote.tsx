import { useEffect, useState } from "react";
import quotes from "../../public/data/quotes.json";

export default function MotivationQuote() {
  const [data, setData] = useState({
    quote: "",
    author: "",
  });

  useEffect(() => {
    async function fetchData() {
      const i = Math.floor(Math.random() * quotes.length);

      setData({
        quote: quotes[i].text,
        author: quotes[i].author,
      });
    }

    fetchData();
  }, []);

  return (
    <div className="space-y-2">
      <h1 className="font-medium text-xl">&quot;{data.quote}&quot;</h1>
      <p>- {data.author}</p>
    </div>
  );
}
