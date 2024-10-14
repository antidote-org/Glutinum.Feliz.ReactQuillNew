module Demo.Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Glutinum.Feliz.ReactQuillNew

open type Glutinum.Feliz.ReactQuillNew.Exports

importSideEffects "react-quill-new/dist/quill.snow.css"

[<ReactComponent>]
let App () =
    ReactQuill [
        reactQuill.value "Hello, World!"
        reactQuill.onChange (fun text delta source editor ->
            console.log text
            console.log delta
        )
    ]

let root = ReactDOM.createRoot(document.getElementById("root"))
root.render(App())
