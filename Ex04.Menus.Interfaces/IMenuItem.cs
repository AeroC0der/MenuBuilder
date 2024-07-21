using System;

namespace Ex04.Menus.Interfaces;

public interface IMenuItem
{
    string Text { get; set; }
    List<IMenuItem>? SubMenuItems { get; set; }

    void Execute();
}
