using System;

namespace Ex04.Menus.Interfaces;

public interface IMenu
{
	void AddMenuItem(IMenuItem i_IMenuItem);

        void RemoveMenuItem(IMenuItem i_IMenuItem);

        void Show();
}
