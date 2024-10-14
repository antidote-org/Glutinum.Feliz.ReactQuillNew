namespace Glutinum.Feliz.ReactQuillNew

open Glutinum.Feliz.ReactQuillNew.Types

module Interop =

    let inline mkReactQuillNewProperty (name: string) (value: obj) : IReactQuillNewProperty =
        unbox (name, value)
