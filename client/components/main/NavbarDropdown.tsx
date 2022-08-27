import { Menu, Transition } from "@headlessui/react";
import clsx from "clsx";
import Link from "next/link";
import { Fragment, PropsWithChildren, ReactNode, useState } from "react";
import { Menu as FMenu, Settings, X } from "react-feather";

export default function NavbarDropdown() {
  const [isOpened, setIsOpened] = useState(false);

  return (
    <Menu as="div" className="relative inline-block text-left">
      <div>
        <Menu.Button className="p-4" onClick={() => setIsOpened(!isOpened)}>
          {isOpened ? <X /> : <FMenu />}
        </Menu.Button>
      </div>

      <Transition
        as={Fragment}
        enter="transition ease-out duration-100"
        enterFrom="transform opacity-0 scale-95"
        enterTo="transform opacity-100 scale-100"
        leave="transition ease-in duration-75"
        leaveFrom="transform opacity-100 scale-100"
        leaveTo="transform opacity-0 scale-95"
      >
        <Menu.Items className="origin-top-right absolute right-0 mt-2 w-40 rounded-md shadow-lg bg-black ring-1 ring-black ring-opacity-5 focus:outline-none">
          <div className="py-1">
            <Menu.Item>
              {({ active }) => (
                <MenuItem
                  href="/"
                  icon={<Settings color="white" />}
                  active={active}
                >
                  Settings
                </MenuItem>
              )}
            </Menu.Item>
            <Menu.Item>
              {({ active }) => (
                <MenuItem
                  href="/"
                  icon={<Settings color="white" />}
                  active={active}
                >
                  Settings
                </MenuItem>
              )}
            </Menu.Item>
            <Menu.Item>
              {({ active }) => (
                <MenuItem
                  href="/"
                  icon={<Settings color="white" />}
                  active={active}
                >
                  Settings
                </MenuItem>
              )}
            </Menu.Item>
          </div>
        </Menu.Items>
      </Transition>
    </Menu>
  );
}

function MenuItem({
  children,
  active,
  icon,
  href,
}: PropsWithChildren<{ active: boolean; icon: ReactNode; href: string }>) {
  return (
    <Link href={href}>
      <a
        className={clsx(
          active ? "bg-gray-100 text-gray-900" : "text-gray-700",
          "block px-4 py-2 text-sm"
        )}
      >
        <span className="flex items-center space-x-2">
          {icon}
          <span className="text-white">{children}</span>
        </span>
      </a>
    </Link>
  );
}
