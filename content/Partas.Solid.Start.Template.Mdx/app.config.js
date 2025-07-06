import { defineConfig } from "@solidjs/start/config";
import devtools from "solid-devtools/vite";
import pkg from "@vinxi/plugin-mdx";

const { default: mdx } = pkg;

export default defineConfig({
    // Change to project name as required
    appRoot: "./Partas.Solid.Start.Template",
    routeDir: "./routes",
    // Recommended to use .fs.jsx extension so that fable clean will not
    // wipe out solid-start files
    extensions: [ 'mdx', 'md' ],
    // Vite config
    vite: {
        plugins:[
            devtools({
                autoname: true
            }),
            mdx.withImports({})({
                jsx: true,
                jsxImportSource: "solid-js",
                providerImportSource: "solid-mdx"
            })
        ],
        server: {
            watch: {
                ignore: [
                    "**/*.fs",
                    "**/*.fsx"
                ]
            }
        }
    },
    // Vinxi/Nitro/SolidStart
    server: {
        // preset: "vercel"
    }
});
