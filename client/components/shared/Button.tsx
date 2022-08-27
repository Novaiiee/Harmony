import clsx from "clsx";
import Link from "next/link";
import { PropsWithChildren } from "react";

type ButtonVariants = "normal" | "outlined";
type ButtonColors = "black" | "pink";

interface ButtonProps {
  variant?: ButtonVariants;
  color?: ButtonColors;
  href?: string;
  px?: number;
  py?: number;
  onClick?: () => void;
}

export default function Button({
  children,
  variant = "normal",
  color = "black",
  href,
  px = 4,
  py = 3,
  ...props
}: PropsWithChildren<ButtonProps>) {
  const baseStyles = `py-${py} px-${px} rounded-md`;

  const mainColor = {
    pink: "pink-600",
    black: "black",
  }[color];

  const styles = clsx(baseStyles, {
    [`bg-${mainColor} border-2 border-${mainColor} text-white transition ease-in-out duration-75 hover:bg-transparent hover:text-${mainColor}`]:
      variant === "normal",
    [``]: variant === "outlined",
  });

  return href ? (
    <Link href={href}>
      <button className={styles} {...props}>
        {children}
      </button>
    </Link>
  ) : (
    <button className={styles} {...props}>
      {children}
    </button>
  );
}
