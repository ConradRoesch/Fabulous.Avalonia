namespace Fabulous.Avalonia

open System.Runtime.CompilerServices
open Avalonia.Animation
open Fabulous
open Fabulous.StackAllocatedCollections

type IFabAnimatable =
    inherit IFabElement

module Animatable =
    let Transitions =
        Attributes.defineAvaloniaListWidgetCollection "Animatable_Transitions" (fun target ->
            let target = (target :?> Animatable)

            if target.Transitions = null then
                let newColl = Transitions()
                target.Transitions <- newColl
                newColl
            else
                target.Transitions)

[<Extension>]
type AnimatableCollectionBuilderExtensions =
    [<Extension>]
    static member inline Yield<'msg, 'marker, 'itemType when 'marker :> IFabAnimatable and 'itemType :> IFabTransition>
        (
            _: AttributeCollectionBuilder<'msg, 'marker, IFabTransition>,
            x: WidgetBuilder<'msg, 'itemType>
        ) : Content<'msg> =
        { Widgets = MutStackArray1.One(x.Compile()) }

    [<Extension>]
    static member inline Yield<'msg, 'marker, 'itemType when 'marker :> IFabAnimatable and 'itemType :> IFabTransition>
        (
            _: AttributeCollectionBuilder<'msg, 'marker, IFabTransition>,
            x: WidgetBuilder<'msg, Memo.Memoized<'itemType>>
        ) : Content<'msg> =
        { Widgets = MutStackArray1.One(x.Compile()) }

    [<Extension>]
    static member inline Yield<'msg, 'marker, 'itemType when 'marker :> IFabAnimatable and 'itemType :> IFabAnimation>
        (
            _: AttributeCollectionBuilder<'msg, 'marker, IFabAnimation>,
            x: WidgetBuilder<'msg, 'itemType>
        ) : Content<'msg> =
        { Widgets = MutStackArray1.One(x.Compile()) }

    [<Extension>]
    static member inline Yield<'msg, 'marker, 'itemType when 'marker :> IFabAnimatable and 'itemType :> IFabAnimation>
        (
            _: AttributeCollectionBuilder<'msg, 'marker, IFabAnimation>,
            x: WidgetBuilder<'msg, Memo.Memoized<'itemType>>
        ) : Content<'msg> =
        { Widgets = MutStackArray1.One(x.Compile()) }

[<Extension>]
type AnimatableCollectionModifiers =
    [<Extension>]
    static member inline transitions(this: WidgetBuilder<'msg, #IFabAnimatable>) =
        AttributeCollectionBuilder<'msg, #IFabAnimatable, IFabTransition>(this, Animatable.Transitions)

    [<Extension>]
    static member inline transition(this: WidgetBuilder<'msg, #IFabAnimatable>, transition: WidgetBuilder<'msg, #IFabTransition>) =
        AttributeCollectionBuilder<'msg, #IFabAnimatable, IFabTransition>(this, Animatable.Transitions) { transition }
