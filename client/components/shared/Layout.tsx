import { PropsWithChildren } from "react";

export default function Layout({ children }: PropsWithChildren) {
  return <div className="w-screen h-screen font-inter">{children}</div>;
}
