from oop import DataBase
import pytest

# def test_wrong_salary():
#     with pytest.raises(ValueError):
#         employee_1 = Employee(1, "Семенов М.А.", "12.12.2000", -100)

def wrong_type_test():
    with pytest.raises(TypeError):
        emp = DataBase.add_student("Test Test 19")
        assert emp == "qwrty"

# def test_wrong_salary():
#     with pytest.raises(ValueError):
#         employee_1 = DataBase.select_by_age(age=19)
