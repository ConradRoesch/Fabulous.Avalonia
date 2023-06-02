namespace Gallery

[<RequireQualifiedAccess>]
type NavigationRoute =
    | AcrylicPage
    | AdornerLayerPage
    | AutoCompleteBoxPage
    | AnimationsPage
    | ButtonsPage
    | BrushesPage
    | ButtonSpinnerPage
    | BorderPage
    | CalendarPage
    | CalendarDatePickerPage
    | CanvasPage
    | CheckBoxPage
    | CarouselPage
    | ComboBoxPage
    | ContextMenuPage
    | ContextFlyoutPage
    | ClippingPage
    | DockPanelPage
    | DropDownButtonPage
    | DrawingPage
    | ExpanderPage
    | FlyoutPage
    | GesturesPage
    | GeometriesPage
    | GlyphRunControlPage
    | GridPage
    | GridSplitterPage
    | ImagePage
    | LabelPage
    | LayoutTransformControlPage
    | LineBoundsDemoControlPage
    | ListBoxPage
    | MenuFlyoutPage
    | MaskedTextBoxPage
    | MenuPage
    | NumericUpDownPage
    | NotificationsPage
    | ProgressBarPage
    | PanelPage
    | PathIconPage
    | PopupPage
    | PageTransitionsPage
    | RepeatButtonPage
    | RadioButtonPage
    | RefreshContainerPage
    | SelectableTextBlockPage
    | SplitButtonPage
    | SliderPage
    | ShapesPage
    | ScrollBarPage
    | SplitViewPage
    | StackPanelPage
    | ScrollViewerPage
    | ToggleSplitButtonPage
    | TextBlockPage
    | TextBoxPage
    | TickBarPage
    | ToggleSwitchPage
    | ToggleButtonPage
    | ToolTipPage
    | TabControlPage
    | TabStripPage
    | TransitionsPage
    | TransformsPage
    | ThemeAwarePage
    | UniformGridPage
    | ViewBoxPage

    static member GetRoute(route: string) =
        match route with
        | "AcrylicPage" -> AcrylicPage
        | "AdornerLayerPage" -> AdornerLayerPage
        | "AutoCompleteBoxPage" -> AutoCompleteBoxPage
        | "AnimationsPage" -> AnimationsPage
        | "ButtonsPage" -> ButtonsPage
        | "BrushesPage" -> BrushesPage
        | "ButtonSpinnerPage" -> ButtonSpinnerPage
        | "BorderPage" -> BorderPage
        | "CalendarPage" -> CalendarPage
        | "CalendarDatePickerPage" -> CalendarDatePickerPage
        | "CanvasPage" -> CanvasPage
        | "CheckBoxPage" -> CheckBoxPage
        | "CarouselPage" -> CarouselPage
        | "ComboBoxPage" -> ComboBoxPage
        | "ContextMenuPage" -> ContextMenuPage
        | "ContextFlyoutPage" -> ContextFlyoutPage
        | "ClippingPage" -> ClippingPage
        | "DockPanelPage" -> DockPanelPage
        | "DropDownButtonPage" -> DropDownButtonPage
        | "DrawingPage" -> DrawingPage
        | "ExpanderPage" -> ExpanderPage
        | "FlyoutPage" -> FlyoutPage
        | "GesturesPage" -> GesturesPage
        | "GeometriesPage" -> GeometriesPage
        | "GlyphRunControlPage" -> GlyphRunControlPage
        | "GridPage" -> GridPage
        | "GridSplitterPage" -> GridSplitterPage
        | "ImagePage" -> ImagePage
        | "LabelPage" -> LabelPage
        | "LayoutTransformControlPage" -> LayoutTransformControlPage
        | "LineBoundsDemoControlPage" -> LineBoundsDemoControlPage
        | "ListBoxPage" -> ListBoxPage
        | "MenuFlyoutPage" -> MenuFlyoutPage
        | "MaskedTextBoxPage" -> MaskedTextBoxPage
        | "MenuPage" -> MenuPage
        | "NumericUpDownPage" -> NumericUpDownPage
        | "NotificationsPage" -> NotificationsPage
        | "ProgressBarPage" -> ProgressBarPage
        | "PanelPage" -> PanelPage
        | "PathIconPage" -> PathIconPage
        | "PopupPage" -> PopupPage
        | "PageTransitionsPage" -> PageTransitionsPage
        | "RepeatButtonPage" -> RepeatButtonPage
        | "RadioButtonPage" -> RadioButtonPage
        | "RefreshContainerPage" -> RefreshContainerPage
        | "SelectableTextBlockPage" -> SelectableTextBlockPage
        | "SplitButtonPage" -> SplitButtonPage
        | "SliderPage" -> SliderPage
        | "ShapesPage" -> ShapesPage
        | "ScrollBarPage" -> ScrollBarPage
        | "SplitViewPage" -> SplitViewPage
        | "StackPanelPage" -> StackPanelPage
        | "ScrollViewerPage" -> ScrollViewerPage
        | "ToggleSplitButtonPage" -> ToggleSplitButtonPage
        | "TextBlockPage" -> TextBlockPage
        | "TextBoxPage" -> TextBoxPage
        | "TickBarPage" -> TickBarPage
        | "ToggleSwitchPage" -> ToggleSwitchPage
        | "ToggleButtonPage" -> ToggleButtonPage
        | "ToolTipPage" -> ToolTipPage
        | "TabControlPage" -> TabControlPage
        | "TabStripPage" -> TabStripPage
        | "TransitionsPage" -> TransitionsPage
        | "TransformsPage" -> TransformsPage
        | "ThemeAwarePage" -> ThemeAwarePage
        | "UniformGridPage" -> UniformGridPage
        | "ViewBoxPage" -> ViewBoxPage
        | _ -> failwithf $"Unknown route: %s{route}"