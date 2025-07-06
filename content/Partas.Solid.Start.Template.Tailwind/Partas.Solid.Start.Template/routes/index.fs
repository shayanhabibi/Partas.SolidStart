module Partas.Solid.Start.Template.routes.index

open Partas.Solid
open Partas.Solid.Meta
open Fable.Core
open Partas.Solid.Router
open Partas.Solid.Start.Template

[<ExportDefault>]
[<SolidComponent>]
let private Home() =
    main(class' = "text-center mx-auto text-gray-700 p-4") {
        Title() { "Partas.Solid.Start.Template" }
        h1(class' = "max-6-xs text-6xl text-sky-700 font-thin uppercase my-16") {
             "Partas.Solid.Start.Template" 
        }
        Counter()
        p(class' = "mt-8") {
            $"Visit{' '}"
            a(href="https://solidjs.com",target="_blank"
              ,class' = "text-sky-600 hover:underline") {
                "solidjs.com"
            }
            $"{' '}to learn how to buld Solid apps."
        }
        p(class' = "my-4") {
            span() {
                "Home"
            }
            $"{' '}-{' '}"
            A(href = "/about", class' = "text-sky-600 hover:underline") {
                "About Page"
            }
            $"{' '}"
        }
    }
