namespace Glutinum.Feliz.ReactQuillNew

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Glutinum.Feliz.ReactQuillNew.Types

type Exports =

    static member inline ReactQuill(properties: #IReactQuillNewProperty seq) =
        Interop.reactApi.createElement (import "default" "react-quill-new", createObj !!properties)

    [<Import("Range", "quill"); EmitConstructor>]
    static member Range(index: float, ?length: float) : Quill.Range = nativeOnly
