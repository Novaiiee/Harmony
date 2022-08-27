import {
  Hydrate,
  QueryClient,
  QueryClientProvider,
} from "@tanstack/react-query";
import type { AppProps } from "next/app";
import { useState } from "react";

import "@fontsource/inter"
import "../styles/globals.css";

import Layout from "../components/shared/Layout";

const MyApp: React.FunctionComponent<AppProps> = (props) => {
  const { Component, pageProps } = props;
  const [client] = useState(() => new QueryClient());

  return (
    <QueryClientProvider client={client}>
      <Hydrate state={pageProps.dehydratedState}>
        <Layout>
          <Component {...pageProps} />
        </Layout>
      </Hydrate>
    </QueryClientProvider>
  );
};

export default MyApp;
