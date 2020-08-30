import { createMuiTheme } from "@material-ui/core/styles";
import purple from "@material-ui/core/colors/purple";
import green from "@material-ui/core/colors/green";
import { ThemeConsumer } from "styled-components";

const mainGrey = "#a9a9a9";
const platinumGrey = "#DFE6E9";
const dimGrey = "#636E72";
const dangerColor = "#FF0000";
const successColor = "#008000";

export default createMuiTheme({
  palette: {
    common: {
      grey: `${mainGrey}`,
    },
    primary: {
      main: `${mainGrey}`,
    },
    secondary: {
      main: `${dangerColor}`,
    },
  },
  typography: {
    tabs: {
      fontFamily: "roboto",
      border: "1px solid #FFFFFF",
      fontSize: "0.8rem",
      minWidth: 10,
    },
  },
});
