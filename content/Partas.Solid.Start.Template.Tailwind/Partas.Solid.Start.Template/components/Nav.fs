namespace Partas.Solid.Start.Template

open Partas.Solid
open Partas.Solid.Router
open Fable.Core

[<Erase>]
type Nav() =
    interface RegularNode
    [<SolidTypeComponent>]
    member props.__ =
        let location = useLocation()
        let active = fun path ->
            if path = location.pathname
            then "border-sky-600"
            else "border-transparent hover:border-sky-600"
        nav(class' = "bg-sky-800") {
            ul(class' = "container flex items-center p-3 text-gray-200") {
                li(class' = $"""border-b-2 {active("/")} mx-1.5 sm:mx-6""") {
                    a(href="/") { "Home" }
                }
                li(class' = $"""border-b-2 {active("/about")} mx-1.5 sm:mx-6""") {
                    a(href="/") { "About" }
                }
            }
        }

