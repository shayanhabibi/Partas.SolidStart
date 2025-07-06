namespace Partas.Solid.Start.Template

open Partas.Solid
open Fable.Core

[<Erase>]
type Counter() =
    interface RegularNode
    [<SolidTypeComponent>]
    member props.__ =
        let count,setCount = createSignal 0
        button(
            class' = "w-[200px] rounded-full bg-gray-100 border-2 border-gray-300
                        focus:border-gray-400 active:border-gray-400 px-[2rem] py[1rem]",
            onClick = fun _ -> setCount.Invoke(fun prev -> prev + 1)
        ) {
            $"Clicks: {count()}"
        }
