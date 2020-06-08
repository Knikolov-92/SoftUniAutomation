using OpenQA.Selenium;



namespace DemoQA.Pages.Interactions
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver)
            : base(driver)
        { }

        public void Open()
        {
            NavigateTo(DRAGGABLE_PAGE_URL);
        }

        public void NavigateToAxisTab()
        {
            ClickOn(NAV_AXIS_TAB);
        }

        public int GetDragMeElementPositionX()
        {
            return GetElementPositionX(DRAG_ME_ELEMENT);
        }

        public int GetDragMeElementPositionY()
        {
            return GetElementPositionY(DRAG_ME_ELEMENT);
        }

        public int GetCoordinateXofWidgetUpperLeftCorner()
        {
            return GetElementPositionX(BOTTOM_LINE_WIDGET);
        }

        public int GetCoordinateYofWidgetUpperLeftCorner()
        {
            return GetElementPositionY(BOTTOM_LINE_WIDGET);
        }

        public int GetCoordinateXofWidgetBottomRightCorner()
        {
            return GetElementPositionX(BOTTOM_LINE_WIDGET)
                   + GetElementSizeWidth(BOTTOM_LINE_WIDGET);
        }

        public int GetCoordinateYofWidgetBottomRightCorner()
        {
            return GetElementPositionY(BOTTOM_LINE_WIDGET)
                   + GetElementSizeHeight(BOTTOM_LINE_WIDGET);
        }

        public int GetCoordinateXofOnlyXelement()
        {
            return GetElementPositionX(ONLY_X_DRAG_ELEMENT);
        }

        public int GetCoordinateYofOnlyXelement()
        {
            return GetElementPositionY(ONLY_X_DRAG_ELEMENT);
        }        

        public int GetCoordinateXofConstraintArea()
        {
            return GetElementPositionX(CONSTRAINT_AREA);
        }

        public int GetCoordinateXofOnlyYelement()
        {
            return GetElementPositionX(ONLY_Y_DRAG_ELEMENT);
        }

        public int GetCoordinateYofOnlyYelement()
        {
            return GetElementPositionY(ONLY_Y_DRAG_ELEMENT);
        }        
    }
}
