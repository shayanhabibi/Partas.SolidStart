module Partas.Solid.Start.Template.routes.about

open Partas.Solid.Start.Template
open Partas.Solid
open Partas.Solid.Router
open Fable.Core

[<SolidComponent>]
[<ExportDefault>]
let private About() =
    main(class' = "text-center mx-auto text-gray-700 p-4") {
        h1(class' = "max-6-xs text-6xl text-sky-700 font-thin uppercase my-16") {
            "About Page"
        }
        Counter()
        p(class' = "mt-8") {
            $"Visit{' '}"
            a(href="https://solidjs.com", target="_blank",
              class'="text-sky-600 hover:underline") {
                "solidjs.com"
            }
            $"{' '}to learn how to build Solid apps."
        }
        p(class' = "my-4") {
            A(href = "/", class' = "text-sky-600 hover:underline") {
                "Home"
            }
            $"{' '}-{' '}"
            span() { "About Page" }
        }
    }
