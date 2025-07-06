namespace Partas.Solid.Start.Template

open Partas.Solid
open Fable.Core
open Fable.Core.JsInterop
open Fable.Core.JS

importSideEffects "./Counter.css"

[<SolidComponent>]
[<ExportDefault>]
let private Counter() =
    let count,setCount = createSignal 0
    button(class' = "increment", type'="button", onClick = fun _ -> setCount.Invoke(fun x -> x + 1)) {
        $"Clicks: {count()}"
    }
