namespace rec Glutinum.Feliz.ReactQuillNew

open Feliz
open Fable.Core
open Fable.Core.JsInterop
open Browser.Types

// Put your exports here
[<Erase>]
[<Interface>]
type reactQuill =

    static member inline custom (key: string) (value: obj) =
        Interop.mkReactQuillNewProperty key value

    static member inline bounds(value: string) =
        Interop.mkReactQuillNewProperty "bounds" value

    static member inline bounds(value: HTMLElement) =
        Interop.mkReactQuillNewProperty "bounds" value

    static member inline children(value: ReactElement) =
        Interop.mkReactQuillNewProperty "children" value

    static member inline className(value: string) =
        Interop.mkReactQuillNewProperty "className" value

    static member inline defaultValue(value: string) =
        Interop.mkReactQuillNewProperty "defaultValue" value

    static member inline defaultValue(value: Quill.DeltaStatic) =
        Interop.mkReactQuillNewProperty "defaultValue" value

    static member inline formats(value: string list) =
        Interop.mkReactQuillNewProperty "formats" (ResizeArray value)

    static member inline id(value: string) =
        Interop.mkReactQuillNewProperty "id" value

    static member inline modules(value: obj) =
        Interop.mkReactQuillNewProperty "modules" value

    static member inline onChange(value: string -> unit) =
        Interop.mkReactQuillNewProperty "onChange" value

    static member inline onChange(value: string -> Quill.DeltaStatic -> unit) =
        Interop.mkReactQuillNewProperty "onChange" (System.Func<_, _, _> value)

    static member inline onChange
        (value: string -> Quill.DeltaStatic -> Quill.EmitterSource -> unit)
        =
        Interop.mkReactQuillNewProperty "onChange" (System.Func<_, _, _, _> value)

    static member inline onChange
        (value: string -> Quill.DeltaStatic -> Quill.EmitterSource -> UnprivilegedEditor -> unit)
        =
        Interop.mkReactQuillNewProperty "onChange" (System.Func<_, _, _, _, _> value)

    static member inline onChangeSelection(value: Range -> unit) =
        Interop.mkReactQuillNewProperty "onChangeSelection" value

    static member inline onChangeSelection(value: Range -> Quill.EmitterSource -> unit) =
        Interop.mkReactQuillNewProperty "onChangeSelection" (System.Func<_, _, _> value)

    static member inline onChangeSelection
        (value: Range -> Quill.EmitterSource -> UnprivilegedEditor -> unit)
        =
        Interop.mkReactQuillNewProperty "onChangeSelection" (System.Func<_, _, _, _> value)

    static member inline onFocus(value: Range -> unit) =
        Interop.mkReactQuillNewProperty "onFocus" value

    static member inline onFocus(value: Range -> Quill.EmitterSource -> unit) =
        Interop.mkReactQuillNewProperty "onFocus" (System.Func<_, _, _> value)

    static member inline onFocus
        (value: Range -> Quill.EmitterSource -> UnprivilegedEditor -> unit)
        =
        Interop.mkReactQuillNewProperty "onFocus" (System.Func<_, _, _, _> value)

    static member inline onBlur(value: Range -> unit) =
        Interop.mkReactQuillNewProperty "onBlur" value

    static member inline onBlur(value: Range -> Quill.EmitterSource -> unit) =
        Interop.mkReactQuillNewProperty "onBlur" (System.Func<_, _, _> value)

    static member inline onBlur(value: Range -> Quill.EmitterSource -> UnprivilegedEditor -> unit) =
        Interop.mkReactQuillNewProperty "onBlur" (System.Func<_, _, _, _> value)

    static member inline onKeyDown(value: KeyboardEvent -> unit) =
        Interop.mkReactQuillNewProperty "onKeyDown" value

    static member inline onKeyPress(value: KeyboardEvent -> unit) =
        Interop.mkReactQuillNewProperty "onKeyPress" value

    static member inline onKeyUp(value: KeyboardEvent -> unit) =
        Interop.mkReactQuillNewProperty "onKeyUp" value

    static member inline placeholder(value: string) =
        Interop.mkReactQuillNewProperty "placeholder" value

    static member inline preserveWhitespace(value: bool) =
        Interop.mkReactQuillNewProperty "preserveWhitespace" value

    static member inline readOnly(value: bool) =
        Interop.mkReactQuillNewProperty "readOnly" value

    static member inline style(value: #IStyleAttribute list) =
        Interop.mkReactQuillNewProperty "style" (createObj !!value)

    static member inline tabIndex(value: int) =
        Interop.mkReactQuillNewProperty "tabIndex" value

    static member inline theme(value: string) =
        Interop.mkReactQuillNewProperty "theme" value

    static member inline value(value: string) =
        Interop.mkReactQuillNewProperty "value" value

    static member inline value(value: Quill.DeltaStatic) =
        Interop.mkReactQuillNewProperty "value" value

[<AllowNullLiteral>]
[<Interface>]
type UnprivilegedEditor =
    abstract member getLength: unit -> float
    abstract member getText: ?range: Quill.Range -> string
    abstract member getText: ?index: float * ?length: float -> string
    abstract member getHTML: (unit -> string) with get, set
    abstract member getSemanticHTML: range: Quill.Range -> string
    abstract member getSemanticHTML: ?index: float * ?length: float -> string
    abstract member getBounds: index: float * ?length: float -> Quill.Bounds option
    abstract member getBounds: index: Quill.Range * ?length: float -> Quill.Bounds option
    abstract member getSelection: focus: bool -> Quill.Range
    abstract member getSelection: ?focus: bool -> Quill.Range option
    abstract member getContents: ?index: float * ?length: float -> Quill.Delta

module Quill =

    [<AllowNullLiteral>]
    [<Interface>]
    type Bounds =
        abstract member bottom: float with get, set
        abstract member height: float with get, set
        abstract member left: float with get, set
        abstract member right: float with get, set
        abstract member top: float with get, set
        abstract member width: float with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Range =
        abstract member index: float with get, set
        abstract member length: float with get, set

    type DeltaStatic = obj

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EmitterSource =
        | api
        | silent
        | user

    type Delta = obj
