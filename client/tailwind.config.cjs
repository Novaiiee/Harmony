/** @type {import("tailwindcss").Config} **/

module.exports = {
	content: ["./components/**/*.tsx", "./pages/**/*.tsx"],
	mode: "jit",
	darkMode: "class",
	theme: {
		extend: {
			flex: {
				1: "1 1 0%",
				2: "2 2 0%",
				3: "3 3 0%",
				4: "4 4 0%",
				5: "5 5 0%"
			},
			height: {
				"10vh": "10vh",
				"20vh": "20vh",
				"30vh": "30vh",
				"40vh": "40vh",
				"50vh": "50vh",
				"60vh": "60vh",
				"70vh": "70vh",
				"80vh": "80vh",
				"90vh": "90vh"
			},
			width: {
				"10vw": "10vw",
				"20vw": "20vw",
				"30vw": "30vw",
				"40vw": "40vw",
				"50vw": "50vw",
				"60vw": "60vw",
				"70vw": "70vw",
				"80vw": "80vw",
				"90vw": "90vw"
			},
			opacity: {
				0: "0",
				5: "0.05",
				10: "0.1",
				20: "0.2",
				25: "0.25",
				30: "0.3",
				40: "0.4",
				50: "0.5",
				60: "0.6",
				70: "0.7",
				75: "0.75",
				80: "0.8",
				90: "0.9",
				95: "0.95",
				100: "1"
			},
			borderWidth: {
				1: "1px"
			},
			fontFamily: {
				inter: ['"Inter"', "sans-serif"],
			}
		}
	},
	plugins: [require("@tailwindcss/forms")]
};