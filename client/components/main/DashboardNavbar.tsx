
import { useEffect, useState } from "react";
import NavbarDropdown from "./NavbarDropdown";

export default function DashboardNavbar() {
  const [date, setDate] = useState("");

  useEffect(() => {
    setDate(new Date().toLocaleDateString());
  }, []);

  return (
    <div className="flex justify-between items-center w-full mb-10 font-medium">
      <div>
        <h1 className="font-medium">Today is {date}</h1>
      </div>
      <div className="flex items-center space-x-10">
        <h1>Welcome back Toheeb!</h1>
        <NavbarDropdown />
      </div>
    </div>
  );
}
