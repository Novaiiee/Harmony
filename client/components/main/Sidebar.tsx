import { useState } from "react";
import { ArrowLeft, ArrowRight, Book, Grid, Home, Smile } from "react-feather";

export default function Sidebar() {
  const [collapsed, setCollapsed] = useState(false);

  return !collapsed ? (
    <div className="w-64 bg-orange-50 flex flex-col h-screen p-8 justify-between border-r-1 border-gray-100">
      <div className="space-y-10">
        <div className="flex items-center justify-between space-x-4 mb-4">
          <span className="flex space-x-2 items-center">
            <Smile />
            <h1 className="font-bold text-xl">Harmony</h1>
          </span>
        </div>
        <div className="flex flex-col space-y-6 items-start">
          <span className="flex space-x-3 ">
            <Home />
            <h3>Home</h3>
          </span>
          <span className="flex space-x-3 ">
            <Grid />
            <h3>Reflections</h3>
          </span>
          <span className="flex space-x-3 ">
            <Book />
            <h3>Mental Wiki</h3>
          </span>
        </div>
      </div>
      <div
        onClick={() => setCollapsed(!collapsed)}
        className="flex items-center space-x-8 p-1 bg-black rounded-lg ring-2 ring-black text-white transition ease-in-out duration-75 hover:text-black hover:bg-transparent"
      >
        <ArrowLeft size={20} />
        <span className="noselect">Collapse</span>
      </div>
    </div>
  ) : (
    <div className="w-14 bg-orange-50 flex flex-col h-screen p-8 justify-between items-center border-r-1 border-gray-100">
      <div className="space-y-10">
        <div className="flex items-center justify-between space-x-6 mb-4">
          <span className="flex space-x-2 items-center">
            <Smile />
          </span>
        </div>
        <div className="flex flex-col space-y-6 items-start">
          <Home />
          <Grid />
          <Book />
        </div>
      </div>
      <ArrowRight
        size={30}
        onClick={() => setCollapsed(!collapsed)}
        className="p-1 bg-black rounded-lg ring-2 ring-black text-white transition ease-in-out duration-75 hover:text-black hover:bg-transparent"
      />
    </div>
  );
}
