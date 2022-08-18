import {
  Hydrate,
  QueryClient,
  QueryClientProvider,
} from "@tanstack/react-query";
import type { AppProps } from "next/app";
import { useState } from "react";

import "../styles/globals.css";
import GlobalStyles from "../styles/globalStyles";

const MyApp: React.FunctionComponent<AppProps> = (props) => {
  const { Component, pageProps } = props;
  const [client] = useState(() => new QueryClient());

  return (
    <QueryClientProvider client={client}>
      <Hydrate state={pageProps.dehydratedState}>
        <GlobalStyles />
        <Component {...pageProps} />
      </Hydrate>
    </QueryClientProvider>
  );
};

export default MyApp;
